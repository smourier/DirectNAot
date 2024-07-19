namespace DirectN.Extensions;

[Serializable]
public class DirectNException : Exception
{
    public const string Prefix = "DXN";

    public DirectNException()
        : base(Prefix + "0001: DirectN exception.")
    {
    }

    public DirectNException(string message)
        : base(Prefix + message)
    {
    }

    public DirectNException(string message, Exception innerException)
        : base(Prefix + message, innerException)
    {
    }

    public DirectNException(Exception innerException)
        : base(null, innerException)
    {
    }

    public static int GetCode(string message)
    {
        if (message == null)
            return -1;

        if (!message.StartsWith(Prefix, StringComparison.Ordinal))
            return -1;

        var pos = message.IndexOf(':', Prefix.Length);
        if (pos < 0)
            return -1;

        if (int.TryParse(message.AsSpan(Prefix.Length, pos - Prefix.Length), NumberStyles.None, CultureInfo.InvariantCulture, out var i))
            return i;

        return -1;
    }

    public int Code => GetCode(Message);
}
