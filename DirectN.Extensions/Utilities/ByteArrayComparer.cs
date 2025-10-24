namespace DirectN.Extensions.Utilities;

public sealed class ByteArrayComparer : IEqualityComparer<byte[]>
{
    public static ByteArrayComparer Instance { get; } = new();

    public bool Equals(byte[]? left, byte[]? right)
    {
        if (left == null || right == null)
            return left == right;

        if (left.Length != right.Length)
            return false;

        for (var i = 0; i < left.Length; i++)
        {
            if (left[i] != right[i])
                return false;
        }
        return true;
    }

    public int GetHashCode(byte[] key)
    {
        ArgumentNullException.ThrowIfNull(key);
        var sum = 0;
        foreach (var cur in key)
        {
            sum += cur;
        }
        return sum;
    }
}