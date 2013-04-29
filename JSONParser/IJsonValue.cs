using System;

public interface IJsonValue 
        : IEquatable<IJsonValue>
    {
    IJsonValue this[string key] {
        get;
        set;
    }
    IJsonValue this[int i] {
        get;
        set;
    }
    object Value { 
        get;
    }
}
