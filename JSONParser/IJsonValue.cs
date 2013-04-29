using System;

public interface IJsonValue 
        : IEquatable<IJsonValue>
    {
    IJsonValue this[string key] {
        get;
        set;
    }
    object Value { 
        get;
    }
}
