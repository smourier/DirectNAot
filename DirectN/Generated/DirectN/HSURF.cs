#nullable enable
namespace DirectN;

public partial struct HSURF : IEquatable<HSURF>, IValueGet<nint>
{
    public static readonly HSURF Null = new();
    
    public nint Value;
    
    public HSURF(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HSURF value && Equals(value);
    public readonly bool Equals(HSURF other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HSURF left, HSURF right) => left.Equals(right);
    public static bool operator !=(HSURF left, HSURF right) => !left.Equals(right);
    public static implicit operator nint(HSURF value) => value.Value;
    public static implicit operator HSURF(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
