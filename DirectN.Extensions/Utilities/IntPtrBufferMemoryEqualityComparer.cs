namespace DirectN.Extensions.Utilities;

public sealed class IntPtrBufferMemoryEqualityComparer : IEqualityComparer<IntPtrBuffer>
{
    public static IntPtrBufferMemoryEqualityComparer Instance { get; } = new();

    public bool Equals(IntPtrBuffer? left, IntPtrBuffer? right)
    {
        if (left == null || right == null)
            return left == right;

        return left.MemoryEqualsTo(right);
    }

    public int GetHashCode(IntPtrBuffer buffer)
    {
        ArgumentNullException.ThrowIfNull(buffer);
        return buffer.DangerousGetHandle().GetHashCode();
    }
}
