using System;

public partial class JSONParser {
    public class JSONTypeError : Exception {
        public JSONTypeError(string message) : base(message) {}
    }
}
