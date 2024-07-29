#nullable enable
namespace DirectN;

public partial struct DMUS_MSCPARAMS : IEquatable<DMUS_MSCPARAMS>
{
    public static readonly DMUS_MSCPARAMS Null = new();
    
    public int ptDefaultPan;
    
    public DMUS_MSCPARAMS(int value) => this.ptDefaultPan = value;
    public override string ToString() => $"0x{ptDefaultPan:x}";
    
    public override readonly bool Equals(object? obj) => obj is DMUS_MSCPARAMS value && Equals(value);
    public readonly bool Equals(DMUS_MSCPARAMS other) => other.ptDefaultPan == ptDefaultPan;
    public override readonly int GetHashCode() => ptDefaultPan.GetHashCode();
    public static bool operator ==(DMUS_MSCPARAMS left, DMUS_MSCPARAMS right) => left.Equals(right);
    public static bool operator !=(DMUS_MSCPARAMS left, DMUS_MSCPARAMS right) => !left.Equals(right);
    public static implicit operator int(DMUS_MSCPARAMS value) => value.ptDefaultPan;
    public static implicit operator DMUS_MSCPARAMS(int value) => new(value);
}
