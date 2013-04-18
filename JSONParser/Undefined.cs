using System;

public partial class JSONParser {
    public static UndefinedType Undefined {
        get {
            return UndefinedType.Instance;
        }
    }

    public class UndefinedType : IValue {
        private static UndefinedType instance;

        private UndefinedType() {}

        public object Value {
            get {
                return Instance;
            }
        }

        public static UndefinedType Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new UndefinedType();
                }
                return instance;
            }
        }

        public IValue this[string key] {
            get {
                return Instance;
            }
            set {
                throw new TypeError(
                    System.String.Format("Cannot set property '{0}' of undefined", key)
                );
            }
        }
    }
}
