#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgettransferstatusoutinfo
public partial struct DDGETTRANSFERSTATUSOUTINFO : IEquatable<DDGETTRANSFERSTATUSOUTINFO>
{
    public static readonly DDGETTRANSFERSTATUSOUTINFO Null = new();
    
    public nuint dwTransferID;
    
    public override readonly bool Equals(object? obj) => obj is DDGETTRANSFERSTATUSOUTINFO value && Equals(value);
    public readonly bool Equals(DDGETTRANSFERSTATUSOUTINFO other) => other.dwTransferID == dwTransferID;
    public override readonly int GetHashCode() => dwTransferID.GetHashCode();
    public static bool operator ==(DDGETTRANSFERSTATUSOUTINFO left, DDGETTRANSFERSTATUSOUTINFO right) => left.Equals(right);
    public static bool operator !=(DDGETTRANSFERSTATUSOUTINFO left, DDGETTRANSFERSTATUSOUTINFO right) => !left.Equals(right);
}
