#nullable enable
namespace DirectN;

public partial struct SPPHRASERULEHANDLE : IEquatable<SPPHRASERULEHANDLE>
{
    public static readonly SPPHRASERULEHANDLE Null = new();
    
    public nint Value;
    
    public SPPHRASERULEHANDLE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPPHRASERULEHANDLE value && Equals(value);
    public readonly bool Equals(SPPHRASERULEHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Equals(right);
    public static bool operator !=(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => !left.Equals(right);
    public static implicit operator nint(SPPHRASERULEHANDLE value) => value.Value;
    public static implicit operator SPPHRASERULEHANDLE(nint value) => new(value);
}
