#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddlockoutinfo
public partial struct DDLOCKOUTINFO : IEquatable<DDLOCKOUTINFO>
{
    public static readonly DDLOCKOUTINFO Null = new();
    
    public nuint dwSurfacePtr;
    
    public override readonly bool Equals(object? obj) => obj is DDLOCKOUTINFO value && Equals(value);
    public readonly bool Equals(DDLOCKOUTINFO other) => other.dwSurfacePtr == dwSurfacePtr;
    public override readonly int GetHashCode() => dwSurfacePtr.GetHashCode();
    public static bool operator ==(DDLOCKOUTINFO left, DDLOCKOUTINFO right) => left.Equals(right);
    public static bool operator !=(DDLOCKOUTINFO left, DDLOCKOUTINFO right) => !left.Equals(right);
}
