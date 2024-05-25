#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_clipper_global
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_CLIPPER_GLOBAL : IEquatable<DD_CLIPPER_GLOBAL>
{
    public static readonly DD_CLIPPER_GLOBAL Null = new();
    
    public nuint dwReserved1;
    
    public override readonly bool Equals(object? obj) => obj is DD_CLIPPER_GLOBAL value && Equals(value);
    public readonly bool Equals(DD_CLIPPER_GLOBAL other) => other.dwReserved1 == dwReserved1;
    public override readonly int GetHashCode() => dwReserved1.GetHashCode();
    public static bool operator ==(DD_CLIPPER_GLOBAL left, DD_CLIPPER_GLOBAL right) => left.Equals(right);
    public static bool operator !=(DD_CLIPPER_GLOBAL left, DD_CLIPPER_GLOBAL right) => !left.Equals(right);
}
