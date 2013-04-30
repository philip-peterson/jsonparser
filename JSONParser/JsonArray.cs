using System;
using System.Text;
using System.Collections.Generic;

public class JsonArray : IJsonValue { 
	private List<IJsonValue> list;

	public JsonArray() {
		this.list = new List<IJsonValue>();
	}

	public JsonArray(List<IJsonValue> list) {
		this.list = new List<IJsonValue>(list);
	}

	public object Value {
		get {
			return list.ToArray();
		}
	}

	public override string ToString() {
		StringBuilder sb = new StringBuilder();
		bool first = true;
		foreach (IJsonValue item in list) {
			if (!first) {
				sb.Append(",");
			}
			first = false;
			sb.Append(item.ToString());
		}
		return sb.ToString();
	}

	public string ToJson() {
		StringBuilder sb = new StringBuilder();
		sb.Append("[");
		bool first = true;
		foreach (IJsonValue item in list) {
			if (!first) {
				sb.Append(",");
			}
			first = false;
			sb.Append(item.ToJson());
		}
		sb.Append("]");
		return sb.ToString();
	}

	public IJsonValue this[int i] {
		get {
			if (i < list.Count) {
				return list[i];
			}
			return JsonUndefined.Instance;
		}
		set {
			if (i == list.Count) {
				list.Add(value);
			}
			else if (i > list.Count) {
				// Fill in every slot from list.Count to i-1 with undefineds
				for (int j = list.Count; j < i; j++) {
					list.Add(JsonUndefined.Instance);
				}
				list.Add(value);
			}
			else {
				list[i] = value;
			}
		}
	}

	public IJsonValue this[string key] {
		get {
			int i;
			bool success = int.TryParse(key, out i);
			if (!success) {
				return JsonUndefined.Instance;
			}
			else {
				return this[i];
			}
		}
		set {
			int i;
			bool success = int.TryParse(key, out i);
			if (success) {
				this[i] = value;
			}
		}
	}



	public bool Equals(IJsonValue other) {
		// Going by JavaScript rules here. We don't know if they want
		// deep or shallow compare, so do neither
		return false;
	}

}
