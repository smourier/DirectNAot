#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercontroldetails_signed
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCONTROLDETAILS_SIGNED : IEquatable<MIXERCONTROLDETAILS_SIGNED>
{
    public static readonly MIXERCONTROLDETAILS_SIGNED Null = new();
    
    public int lValue;
    
    public MIXERCONTROLDETAILS_SIGNED(int value) => this.lValue = value;
    public override string ToString() => $"0x{lValue:x}";
    
    public override readonly bool Equals(object? obj) => obj is MIXERCONTROLDETAILS_SIGNED value && Equals(value);
    public readonly bool Equals(MIXERCONTROLDETAILS_SIGNED other) => other.lValue == lValue;
    public override readonly int GetHashCode() => lValue.GetHashCode();
    public static bool operator ==(MIXERCONTROLDETAILS_SIGNED left, MIXERCONTROLDETAILS_SIGNED right) => left.Equals(right);
    public static bool operator !=(MIXERCONTROLDETAILS_SIGNED left, MIXERCONTROLDETAILS_SIGNED right) => !left.Equals(right);
    public static implicit operator int(MIXERCONTROLDETAILS_SIGNED value) => value.lValue;
    public static implicit operator MIXERCONTROLDETAILS_SIGNED(int value) => new(value);
}
