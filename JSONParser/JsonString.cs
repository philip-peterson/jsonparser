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

    public IJsonValue this[string key] {
        get {
            return JsonUndefined.Instance;
        }
        set { }
    }

    public String ToString() {
        return Value;
    }

    public bool Equals(IJsonValue other) {
        // TODO this part needs work
        if (other is JsonString) {
            return ((JsonString)other).Value.Equals(val);
        }
        else if (other is string) {
            return ((string)other).Equals(val);
        }
        else {
            return false;
        }
    }

}
