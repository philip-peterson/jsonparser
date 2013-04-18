public partial class JSONParser {
    public class String : IValue { 
        private string val;

        public object Value {
            get {
                return val;
            }
        }

        public String(string val) {
            if (val == null) {
                // I swear it's what JavaScript does
                this.val = "null";
                return;
            }
            this.val = val;
        }

        public IValue this[string key] {
            get {
                return Undefined;
            }
            set { }
        }

        public bool Equals(object other) {
            // TODO this part needs work
            if (other is String) {
                return ((String)other).Value.Equals(val);
            }
            else if (other is string) {
                return ((string)other).Equals(val);
            }
            else {
                return false;
            }
        }

    }
}
