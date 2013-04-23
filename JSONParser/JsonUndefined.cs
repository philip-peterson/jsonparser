using System;

public class JsonUndefined : IJsonValue {
    private static JsonUndefined instance;

    private JsonUndefined() {}

    public object Value {
        get {
            return Instance;
        }
    }
    
    public bool Equals(JsonUndefined other) {
        return true;
    }

    public static JsonUndefined Instance
    {
        get 
        {
            if (instance == null)
            {
                instance = new JsonUndefined();
            }
            return instance;
        }
    }

    public IJsonValue this[string key] {
        get {
            return Instance;
        }
        set {
            throw new JsonTypeError(
                System.String.Format("Cannot set property '{0}' of undefined", key)
            );
        }
    }
}