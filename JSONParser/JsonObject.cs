using System;
using System.Text;
using System.Collections.Generic;

public class JsonObject : IJsonValue { 
	private Dictionary<string, IJsonValue> dict;

	public JsonObject() {
		this.dict = new Dictionary<string, IJsonValue>();
	}

	public object Value {
		get {
			return new Dictionary<string, IJsonValue>(dict);
		}
	}

	public override string ToString() {
		return "[object Object]";
	}

	public string ToJson() {
		StringBuilder sb = new StringBuilder();
		sb.Append("{");
		bool first = true;
		foreach (KeyValuePair<string, IJsonValue> kvp in dict) {
			if (!first) {
				sb.Append(", ");
			}
			first = false;
			sb.Append(JsonString.FormatStringJson(kvp.Key));
			sb.Append(": ");
			sb.Append(kvp.Value.ToJson());
		}
		sb.Append("}");
		return sb.ToString();
	}

	public IJsonValue this[int i] {
		get {
			return this[i.ToString()];
		}
		set {
			this[i.ToString()] = value;
		}
	}

	public IJsonValue this[string key] {
		get {
			return dict[key];
		}
		set {
			dict[key] = value;
		}
	}



	public bool Equals(IJsonValue other) {
		// Going by JavaScript rules here. We don't know if they want
		// deep or shallow compare, so do neither
		return false;
	}

}
