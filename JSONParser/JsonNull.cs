public partial class JsonUtil {
    public static bool IsNull(object x) {
        bool isOfType = (x is JsonNull);
        // I do it this seemingly convoluted way for a reason:
        // http://stackoverflow.com/questions/6417902/checking-if-object-is-null-in-c-sharp
        if (x != null) {
            if (isOfType) {
                return true;
            }
            return false;
        }
        return true;
    }
}

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
    
    public bool Equals (JsonUndefined other) { // let's not do type coercion. confuses people.
        return false;
    }
}
