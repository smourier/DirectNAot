#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/ns-amvideo-am_framestep_step
public partial struct AM_FRAMESTEP_STEP : IEquatable<AM_FRAMESTEP_STEP>
{
    public static readonly AM_FRAMESTEP_STEP Null = new();
    
    public uint dwFramesToStep;
    
    public AM_FRAMESTEP_STEP(uint value) => this.dwFramesToStep = value;
    public override string ToString() => $"0x{dwFramesToStep:x}";
    
    public override readonly bool Equals(object? obj) => obj is AM_FRAMESTEP_STEP value && Equals(value);
    public readonly bool Equals(AM_FRAMESTEP_STEP other) => other.dwFramesToStep == dwFramesToStep;
    public override readonly int GetHashCode() => dwFramesToStep.GetHashCode();
    public static bool operator ==(AM_FRAMESTEP_STEP left, AM_FRAMESTEP_STEP right) => left.Equals(right);
    public static bool operator !=(AM_FRAMESTEP_STEP left, AM_FRAMESTEP_STEP right) => !left.Equals(right);
    public static implicit operator uint(AM_FRAMESTEP_STEP value) => value.dwFramesToStep;
    public static implicit operator AM_FRAMESTEP_STEP(uint value) => new(value);
}
