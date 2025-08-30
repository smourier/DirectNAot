#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_clipper_local
public partial struct DD_CLIPPER_LOCAL : IEquatable<DD_CLIPPER_LOCAL>, IValueGet<nuint>
{
    public static readonly DD_CLIPPER_LOCAL Null = new();
    
    public nuint dwReserved1;
    
    public DD_CLIPPER_LOCAL(nuint value) => this.dwReserved1 = value;
    public override string ToString() => $"0x{dwReserved1:x}";
    
    public override readonly bool Equals(object? obj) => obj is DD_CLIPPER_LOCAL value && Equals(value);
    public readonly bool Equals(DD_CLIPPER_LOCAL other) => other.dwReserved1 == dwReserved1;
    public override readonly int GetHashCode() => dwReserved1.GetHashCode();
    public static bool operator ==(DD_CLIPPER_LOCAL left, DD_CLIPPER_LOCAL right) => left.Equals(right);
    public static bool operator !=(DD_CLIPPER_LOCAL left, DD_CLIPPER_LOCAL right) => !left.Equals(right);
    public static implicit operator nuint(DD_CLIPPER_LOCAL value) => value.dwReserved1;
    public static implicit operator DD_CLIPPER_LOCAL(nuint value) => new(value);
    
    readonly nuint IValueGet<nuint>.GetValue() => dwReserved1;
    readonly object? IValueGet.GetValue() => dwReserved1;
}
