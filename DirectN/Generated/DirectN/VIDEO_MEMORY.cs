#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_MEMORY : IEquatable<VIDEO_MEMORY>
{
    public static readonly VIDEO_MEMORY Null = new();
    
    public nint RequestedVirtualAddress;
    
    public override readonly bool Equals(object? obj) => obj is VIDEO_MEMORY value && Equals(value);
    public readonly bool Equals(VIDEO_MEMORY other) => other.RequestedVirtualAddress == RequestedVirtualAddress;
    public override readonly int GetHashCode() => RequestedVirtualAddress.GetHashCode();
    public static bool operator ==(VIDEO_MEMORY left, VIDEO_MEMORY right) => left.Equals(right);
    public static bool operator !=(VIDEO_MEMORY left, VIDEO_MEMORY right) => !left.Equals(right);
}
