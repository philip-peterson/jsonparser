using System;
using System.Collections.Generic;

public class JsonArray : IJsonValue { 
    private string val;
    private List<IJsonValue> list;

    public JsonArray() {
        this.list = new List<IJsonValue>();
    }

    public JsonArray(List<IJsonValue> list) {
        this.list = new List<IJsonValue>(list);
    }

    public object Value {
        get {
            return val;
        }
    }

    public string ToString() {
        return "[Array object]"; // TODO
    }


    public IJsonValue this[int i] {
        get {
            if (i < list.Count) {
                return list[i];
            }
            return JsonUndefined.Instance;
        }
        set {
            if (i == list.Count) {
                list.Add(value);
            }
            else if (i > list.Count) {
                // Fill in every slot from list.Count to i-1 with undefineds
                for (int j = list.Count; j < i; j++) {
                    list.Add(JsonUndefined.Instance);
                }
                list.Add(value);
            }
            else {
                list[i] = value;
            }
        }
    }

    public IJsonValue this[string key] {
        get {
            int i;
            bool success = int.TryParse(key, out i);
            if (!success) {
                return JsonUndefined.Instance;
            }
            else {
                return this[i];
            }
        }
        set {
            int i;
            bool success = int.TryParse(key, out i);
            if (success) {
                this[i] = value;
            }
        }
    }



    public bool Equals(IJsonValue other) {
        // Going by JavaScript rules here. We don't know if they want
        // deep or shallow compare, so do neither
        return false;
    }

}
