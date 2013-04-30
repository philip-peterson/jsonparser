using System;

public class JsonNumber : IJsonValue {
    private double val;

    public JsonNumber(double x) {
        this.val = x;
    }
    public JsonNumber(float x) {
        this.val = x;
    }
    public JsonNumber(int x) {
        this.val = x;
    }

    public IJsonValue this[string key] {
        get {
            return JsonUndefined.Instance;
        }
        set {
        }
    }

    public override string ToString() {
        return val.ToString();
    }

    public string ToJson() {
        return ToString();
    }

    public object Value {
        get { return val; }
    }

    public bool Equals(IJsonValue other) {
        if (other is JsonNumber) {
            return (double)(((JsonNumber)other).Value) == val;
        }
        return false;
    }
}
