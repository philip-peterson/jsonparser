using System;

public interface IJsonValue 
        : IEquatable<JsonUndefined>//,
        //IEquatable<object>
    {
    IJsonValue this[string key] {
        get;
        set;
    }
    object Value { 
        get;
    }
}
