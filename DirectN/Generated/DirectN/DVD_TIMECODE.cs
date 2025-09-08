#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_timecode
public partial struct DVD_TIMECODE : IEquatable<DVD_TIMECODE>, IValueGet<uint>
{
    public static readonly DVD_TIMECODE Null = new();
    
    public uint _bitfield;
    
    public DVD_TIMECODE(uint value) => this._bitfield = value;
    public override readonly string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is DVD_TIMECODE value && Equals(value);
    public readonly bool Equals(DVD_TIMECODE other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(DVD_TIMECODE left, DVD_TIMECODE right) => left.Equals(right);
    public static bool operator !=(DVD_TIMECODE left, DVD_TIMECODE right) => !left.Equals(right);
    public static implicit operator uint(DVD_TIMECODE value) => value._bitfield;
    public static implicit operator DVD_TIMECODE(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => _bitfield;
    readonly object? IValueGet.GetValue() => _bitfield;
}
