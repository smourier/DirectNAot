#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetirqinfo
public partial struct DDGETIRQINFO : IEquatable<DDGETIRQINFO>
{
    public static readonly DDGETIRQINFO Null = new();
    
    public uint dwFlags;
    
    public DDGETIRQINFO(uint value) => this.dwFlags = value;
    public override string ToString() => $"0x{dwFlags:x}";
    
    public override readonly bool Equals(object? obj) => obj is DDGETIRQINFO value && Equals(value);
    public readonly bool Equals(DDGETIRQINFO other) => other.dwFlags == dwFlags;
    public override readonly int GetHashCode() => dwFlags.GetHashCode();
    public static bool operator ==(DDGETIRQINFO left, DDGETIRQINFO right) => left.Equals(right);
    public static bool operator !=(DDGETIRQINFO left, DDGETIRQINFO right) => !left.Equals(right);
    public static implicit operator uint(DDGETIRQINFO value) => value.dwFlags;
    public static implicit operator DDGETIRQINFO(uint value) => new(value);
}
