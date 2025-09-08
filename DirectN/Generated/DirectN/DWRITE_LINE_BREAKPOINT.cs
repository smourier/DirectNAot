#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_line_breakpoint
public partial struct DWRITE_LINE_BREAKPOINT : IEquatable<DWRITE_LINE_BREAKPOINT>, IValueGet<byte>
{
    public static readonly DWRITE_LINE_BREAKPOINT Null = new();
    
    public byte _bitfield;
    
    public DWRITE_LINE_BREAKPOINT(byte value) => this._bitfield = value;
    public override readonly string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is DWRITE_LINE_BREAKPOINT value && Equals(value);
    public readonly bool Equals(DWRITE_LINE_BREAKPOINT other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(DWRITE_LINE_BREAKPOINT left, DWRITE_LINE_BREAKPOINT right) => left.Equals(right);
    public static bool operator !=(DWRITE_LINE_BREAKPOINT left, DWRITE_LINE_BREAKPOINT right) => !left.Equals(right);
    public static implicit operator byte(DWRITE_LINE_BREAKPOINT value) => value._bitfield;
    public static implicit operator DWRITE_LINE_BREAKPOINT(byte value) => new(value);
    
    readonly byte IValueGet<byte>.GetValue() => _bitfield;
    readonly object? IValueGet.GetValue() => _bitfield;
}
