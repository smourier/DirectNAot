#nullable enable
namespace DirectN;

public partial struct DPI_AWARENESS_CONTEXT : IEquatable<DPI_AWARENESS_CONTEXT>, IValueGet<nint>
{
    public static readonly DPI_AWARENESS_CONTEXT Null = new();
    
    public nint Value;
    
    public DPI_AWARENESS_CONTEXT(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is DPI_AWARENESS_CONTEXT value && Equals(value);
    public readonly bool Equals(DPI_AWARENESS_CONTEXT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) => left.Equals(right);
    public static bool operator !=(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) => !left.Equals(right);
    public static implicit operator nint(DPI_AWARENESS_CONTEXT value) => value.Value;
    public static implicit operator DPI_AWARENESS_CONTEXT(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
