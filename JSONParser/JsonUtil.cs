using System;

public class JsonUtil {
    public static bool IsNull(object x) {
        bool isOfType = (x is JsonNull);
        // I do it this seemingly convoluted way for a reason:
        // http://stackoverflow.com/questions/6417902/checking-if-object-is-null-in-c-sharp
        if (x != null) {
            if (isOfType) {
                return true;
            }
            return false;
        }
        return true;
    }
}
