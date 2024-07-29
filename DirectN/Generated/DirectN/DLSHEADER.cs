#nullable enable
namespace DirectN;

public partial struct DLSHEADER : IEquatable<DLSHEADER>
{
    public static readonly DLSHEADER Null = new();
    
    public uint cInstruments;
    
    public DLSHEADER(uint value) => this.cInstruments = value;
    public override string ToString() => $"0x{cInstruments:x}";
    
    public override readonly bool Equals(object? obj) => obj is DLSHEADER value && Equals(value);
    public readonly bool Equals(DLSHEADER other) => other.cInstruments == cInstruments;
    public override readonly int GetHashCode() => cInstruments.GetHashCode();
    public static bool operator ==(DLSHEADER left, DLSHEADER right) => left.Equals(right);
    public static bool operator !=(DLSHEADER left, DLSHEADER right) => !left.Equals(right);
    public static implicit operator uint(DLSHEADER value) => value.cInstruments;
    public static implicit operator DLSHEADER(uint value) => new(value);
}
