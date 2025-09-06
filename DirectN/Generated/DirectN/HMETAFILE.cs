#nullable enable
namespace DirectN;

public partial struct HMETAFILE : IEquatable<HMETAFILE>, IValueGet<nint>
{
    public static readonly HMETAFILE Null = new();
    
    public nint Value;
    
    public HMETAFILE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HMETAFILE value && Equals(value);
    public readonly bool Equals(HMETAFILE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMETAFILE left, HMETAFILE right) => left.Equals(right);
    public static bool operator !=(HMETAFILE left, HMETAFILE right) => !left.Equals(right);
    public static implicit operator nint(HMETAFILE value) => value.Value;
    public static implicit operator HMETAFILE(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
