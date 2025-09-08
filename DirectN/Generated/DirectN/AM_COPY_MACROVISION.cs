#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_copy_macrovision
public partial struct AM_COPY_MACROVISION : IEquatable<AM_COPY_MACROVISION>, IValueGet<uint>
{
    public static readonly AM_COPY_MACROVISION Null = new();
    
    public uint MACROVISIONLevel;
    
    public AM_COPY_MACROVISION(uint value) => this.MACROVISIONLevel = value;
    public override readonly string ToString() => $"0x{MACROVISIONLevel:x}";
    
    public override readonly bool Equals(object? obj) => obj is AM_COPY_MACROVISION value && Equals(value);
    public readonly bool Equals(AM_COPY_MACROVISION other) => other.MACROVISIONLevel == MACROVISIONLevel;
    public override readonly int GetHashCode() => MACROVISIONLevel.GetHashCode();
    public static bool operator ==(AM_COPY_MACROVISION left, AM_COPY_MACROVISION right) => left.Equals(right);
    public static bool operator !=(AM_COPY_MACROVISION left, AM_COPY_MACROVISION right) => !left.Equals(right);
    public static implicit operator uint(AM_COPY_MACROVISION value) => value.MACROVISIONLevel;
    public static implicit operator AM_COPY_MACROVISION(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => MACROVISIONLevel;
    readonly object? IValueGet.GetValue() => MACROVISIONLevel;
}
