using System.Text;

public class JsonBoolean : IJsonValue { 
	private bool val;

	public object Value {
		get {
			return val;
		}
	}

	public JsonBoolean(bool val) {
		this.val = val;
	}

	public IJsonValue this[string key] {
		get {
			return JsonUndefined.Instance;
		}
		set { }
	}

	public override string ToString() {
		return val ? "true" : "false";
	}

	public string ToJson() {
		return ToString();
	}

	public bool Equals(IJsonValue other) {
		if (other is JsonBoolean) {
			return val == (bool)other.Value;
		}
		return false;
	}

}
