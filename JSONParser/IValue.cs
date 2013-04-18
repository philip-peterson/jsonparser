using System;

public partial class JSONParser {
    public interface IValue : 
            IEquatable<UndefinedType>,
            IEquatable<object>
        {
        IValue this[string key] {
            get;
            set;
        }
        object Value { 
            get;
        }
    }
}
