using System;

public partial class JSONParser {
    public class JSONUndefined : IJSONValue {
        private static JSONUndefined instance;

        private JSONUndefined() {}

        public object Value {
            get {
                return Instance;
            }
        }

        public static JSONUndefined Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new JSONUndefined();
                }
                return instance;
            }
        }

        public IJSONValue this[string key] {
            get {
                return Instance;
            }
            set {
                throw new JSONTypeError(String.Format("Cannot set property '{0}' of undefined", key));
            }
        }
    }
}
