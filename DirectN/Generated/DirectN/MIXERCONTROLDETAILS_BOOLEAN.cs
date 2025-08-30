#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercontroldetails_boolean
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCONTROLDETAILS_BOOLEAN : IEquatable<MIXERCONTROLDETAILS_BOOLEAN>, IValueGet<int>
{
    public static readonly MIXERCONTROLDETAILS_BOOLEAN Null = new();
    
    public int fValue;
    
    public MIXERCONTROLDETAILS_BOOLEAN(int value) => this.fValue = value;
    public override string ToString() => $"0x{fValue:x}";
    
    public override readonly bool Equals(object? obj) => obj is MIXERCONTROLDETAILS_BOOLEAN value && Equals(value);
    public readonly bool Equals(MIXERCONTROLDETAILS_BOOLEAN other) => other.fValue == fValue;
    public override readonly int GetHashCode() => fValue.GetHashCode();
    public static bool operator ==(MIXERCONTROLDETAILS_BOOLEAN left, MIXERCONTROLDETAILS_BOOLEAN right) => left.Equals(right);
    public static bool operator !=(MIXERCONTROLDETAILS_BOOLEAN left, MIXERCONTROLDETAILS_BOOLEAN right) => !left.Equals(right);
    public static implicit operator int(MIXERCONTROLDETAILS_BOOLEAN value) => value.fValue;
    public static implicit operator MIXERCONTROLDETAILS_BOOLEAN(int value) => new(value);
    
    readonly int IValueGet<int>.GetValue() => fValue;
    readonly object? IValueGet.GetValue() => fValue;
}
