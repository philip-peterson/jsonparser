public partial class JSONParser {
    public static bool IsNull(object x) {

        // I do it this seemingly convoluted way for a reason:
        // http://stackoverflow.com/questions/6417902/checking-if-object-is-null-in-c-sharp
        if (x != null) {
            if (x is NullType) { // For some reason this line is causing a lot of trouble...
                return true;
            }
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
        public NullType() {
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
