#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddlockoutinfo
public partial struct DDLOCKOUTINFO : IEquatable<DDLOCKOUTINFO>, IValueGet<nuint>
{
    public static readonly DDLOCKOUTINFO Null = new();
    
    public nuint dwSurfacePtr;
    
    public DDLOCKOUTINFO(nuint value) => this.dwSurfacePtr = value;
    public override string ToString() => $"0x{dwSurfacePtr:x}";
    
    public override readonly bool Equals(object? obj) => obj is DDLOCKOUTINFO value && Equals(value);
    public readonly bool Equals(DDLOCKOUTINFO other) => other.dwSurfacePtr == dwSurfacePtr;
    public override readonly int GetHashCode() => dwSurfacePtr.GetHashCode();
    public static bool operator ==(DDLOCKOUTINFO left, DDLOCKOUTINFO right) => left.Equals(right);
    public static bool operator !=(DDLOCKOUTINFO left, DDLOCKOUTINFO right) => !left.Equals(right);
    public static implicit operator nuint(DDLOCKOUTINFO value) => value.dwSurfacePtr;
    public static implicit operator DDLOCKOUTINFO(nuint value) => new(value);
    
    readonly nuint IValueGet<nuint>.GetValue() => dwSurfacePtr;
    readonly object? IValueGet.GetValue() => dwSurfacePtr;
}
