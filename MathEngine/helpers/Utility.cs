public static class Utility
{
    public static bool IsNonNegativeInteger(object value)
    {
        return value is int intValue && intValue >= 0;
    }
}
