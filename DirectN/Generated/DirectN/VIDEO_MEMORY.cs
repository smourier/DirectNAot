#nullable enable
namespace DirectN;

public partial struct VIDEO_MEMORY : IEquatable<VIDEO_MEMORY>, IValueGet<nint>
{
    public static readonly VIDEO_MEMORY Null = new();
    
    public nint RequestedVirtualAddress;
    
    public VIDEO_MEMORY(nint value) => this.RequestedVirtualAddress = value;
    public override readonly string ToString() => $"0x{RequestedVirtualAddress:x}";
    
    public override readonly bool Equals(object? obj) => obj is VIDEO_MEMORY value && Equals(value);
    public readonly bool Equals(VIDEO_MEMORY other) => other.RequestedVirtualAddress == RequestedVirtualAddress;
    public override readonly int GetHashCode() => RequestedVirtualAddress.GetHashCode();
    public static bool operator ==(VIDEO_MEMORY left, VIDEO_MEMORY right) => left.Equals(right);
    public static bool operator !=(VIDEO_MEMORY left, VIDEO_MEMORY right) => !left.Equals(right);
    public static implicit operator nint(VIDEO_MEMORY value) => value.RequestedVirtualAddress;
    public static implicit operator VIDEO_MEMORY(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => RequestedVirtualAddress;
    readonly object? IValueGet.GetValue() => RequestedVirtualAddress;
}
