using System;

public class JsonNull: IJsonValue {
    public JsonNull() {
    }
    public object Value {
        get {
            return null;
        }
    }
    public IJsonValue this[string key] {
        get {
            throw new JsonTypeError(System.String.Format("Cannot read property '{0}' of null", key));
        }
        set {
            throw new JsonTypeError(System.String.Format("Cannot set property '{0}' of null", key));
        }
    }

    public string ToString() {
        return "null";
    }
    
    public bool Equals (IJsonValue other) { // let's not do type coercion. confuses people.
        return JsonUtil.IsNull(other);
    }
}
