#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddtransferoutinfo
public partial struct DDTRANSFEROUTINFO : IEquatable<DDTRANSFEROUTINFO>, IValueGet<uint>
{
    public static readonly DDTRANSFEROUTINFO Null = new();
    
    public uint dwBufferPolarity;
    
    public DDTRANSFEROUTINFO(uint value) => this.dwBufferPolarity = value;
    public override string ToString() => $"0x{dwBufferPolarity:x}";
    
    public override readonly bool Equals(object? obj) => obj is DDTRANSFEROUTINFO value && Equals(value);
    public readonly bool Equals(DDTRANSFEROUTINFO other) => other.dwBufferPolarity == dwBufferPolarity;
    public override readonly int GetHashCode() => dwBufferPolarity.GetHashCode();
    public static bool operator ==(DDTRANSFEROUTINFO left, DDTRANSFEROUTINFO right) => left.Equals(right);
    public static bool operator !=(DDTRANSFEROUTINFO left, DDTRANSFEROUTINFO right) => !left.Equals(right);
    public static implicit operator uint(DDTRANSFEROUTINFO value) => value.dwBufferPolarity;
    public static implicit operator DDTRANSFEROUTINFO(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => dwBufferPolarity;
    readonly object? IValueGet.GetValue() => dwBufferPolarity;
}
