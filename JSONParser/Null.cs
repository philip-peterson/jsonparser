public partial class JSONParser {
    public static bool IsNull(object x) {
        if (x is NullType) {
            return true;
        }

        // I do it this way for a reason:
        // http://stackoverflow.com/questions/6417902/checking-if-object-is-null-in-c-sharp
        if (x != null) {
            return false;
        }
        return true;
    }

    public class NullType : IValue {
        public object Value {
            get {
                return null;
            }
        }
        public IValue this[string key] {
            get {
                throw new TypeError(System.String.Format("Cannot read property '{0}' of null", key));
            }
            set {
                throw new TypeError(System.String.Format("Cannot set property '{0}' of null", key));
            }
        }
    }
}
