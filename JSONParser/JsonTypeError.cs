using System;

public class JsonTypeError : Exception {
    public JsonTypeError(string message) : base(message) {}
}
