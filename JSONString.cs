public class JSONString : IJSONValue { 
    private string val;

    public object Value {
        get {
            return val;
        }
    }

    public JSONString(string val) {
        if (val == null) {
            // I swear it's what JavaScript does
            this.val = "null";
            return;
        }
        this.val = val;
    }

    //public 

    public IJSONValue this[string key] {
        get {
            return JSONUndefined.Instance;
        }
        set { }
    }

    public bool Equals(object other) {
        // TODO this part needs work
        if (other is JSONString) {
            return ((JSONString)other).Value.Equals(val);
        }
        else if (other is string) {
            return ((string)other).Equals(val);
        }
        else {
            return false;
        }
    }

}
