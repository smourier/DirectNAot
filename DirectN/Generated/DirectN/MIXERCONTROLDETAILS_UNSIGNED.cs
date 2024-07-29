#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercontroldetails_unsigned
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCONTROLDETAILS_UNSIGNED : IEquatable<MIXERCONTROLDETAILS_UNSIGNED>
{
    public static readonly MIXERCONTROLDETAILS_UNSIGNED Null = new();
    
    public uint dwValue;
    
    public MIXERCONTROLDETAILS_UNSIGNED(uint value) => this.dwValue = value;
    public override string ToString() => $"0x{dwValue:x}";
    
    public override readonly bool Equals(object? obj) => obj is MIXERCONTROLDETAILS_UNSIGNED value && Equals(value);
    public readonly bool Equals(MIXERCONTROLDETAILS_UNSIGNED other) => other.dwValue == dwValue;
    public override readonly int GetHashCode() => dwValue.GetHashCode();
    public static bool operator ==(MIXERCONTROLDETAILS_UNSIGNED left, MIXERCONTROLDETAILS_UNSIGNED right) => left.Equals(right);
    public static bool operator !=(MIXERCONTROLDETAILS_UNSIGNED left, MIXERCONTROLDETAILS_UNSIGNED right) => !left.Equals(right);
    public static implicit operator uint(MIXERCONTROLDETAILS_UNSIGNED value) => value.dwValue;
    public static implicit operator MIXERCONTROLDETAILS_UNSIGNED(uint value) => new(value);
}
