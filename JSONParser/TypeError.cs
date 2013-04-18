using System;

public partial class JSONParser {
    public class TypeError : Exception {
        public TypeError(string message) : base(message) {}
    }
}
