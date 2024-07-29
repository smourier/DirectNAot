#nullable enable
namespace DirectN;

public partial struct HENHMETAFILE : IEquatable<HENHMETAFILE>
{
    public static readonly HENHMETAFILE Null = new();
    
    public nint Value;
    
    public HENHMETAFILE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HENHMETAFILE value && Equals(value);
    public readonly bool Equals(HENHMETAFILE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HENHMETAFILE left, HENHMETAFILE right) => left.Equals(right);
    public static bool operator !=(HENHMETAFILE left, HENHMETAFILE right) => !left.Equals(right);
    public static implicit operator nint(HENHMETAFILE value) => value.Value;
    public static implicit operator HENHMETAFILE(nint value) => new(value);
}
