using System.Text;

public class JsonString : IJsonValue { 
	private string val;

	public object Value {
		get {
			return val;
		}
	}

	public JsonString(string val) {
		if (val == null) {
			// I swear it's what JavaScript does
			this.val = "null";
			return;
		}
		this.val = val;
	}

	public JsonString(JsonUndefined u) {
		this.val = u.ToString();
	}

	public JsonString(JsonNumber n) {
		this.val = n.ToString();
	}

	public IJsonValue this[string key] {
		get {
			return JsonUndefined.Instance;
		}
		set { }
	}

	public override string ToString() {
		return val;
	}

	public string ToJson() {
		StringBuilder sb = new StringBuilder();
		sb.Append('"');
		foreach (char c in val) {
			if (c.Equals('\\')) {
				sb.Append("\\\\");
			}
			else if (c.Equals('\b')) {
				sb.Append("\\b");
			}
			else if (c.Equals('\f')) {
				sb.Append("\\f");
			}
			else if (c.Equals('\n')) {
				sb.Append("\\n");
			}
			else if (c.Equals('\r')) {
				sb.Append("\\r");
			}
			else if (c.Equals('\t')) {
				sb.Append("\\t");
			}
			else {
				sb.Append(c);
			}
		}
		sb.Append('"');
		return sb.ToString();
	}

	public bool Equals(IJsonValue other) {
		if (other is JsonString) {
			return ((JsonString)other).Value.Equals(val);
		}
		return false;
	}

	public bool Equals(string other) {
		return other.Equals(val);
	}

}
