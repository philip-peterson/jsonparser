using System;

public partial class JSONParser {
    public interface IValue : IEquatable<JSONParser.Undefined> {
        IValue this[string key] {
            get;
            set;
        }
        object Value { 
            get;
        }
        bool Equals(object t);
    }
}
