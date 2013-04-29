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

    public string ToString() {
        return val;
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
