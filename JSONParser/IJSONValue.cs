public interface IJSONValue {
    IJSONValue this[string key] {
        get;
        set;
    }
    object Value { 
        get;
    }
    bool Equals(object t);
}
