#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgettransferstatusoutinfo
public partial struct DDGETTRANSFERSTATUSOUTINFO : IEquatable<DDGETTRANSFERSTATUSOUTINFO>, IValueGet<nuint>
{
    public static readonly DDGETTRANSFERSTATUSOUTINFO Null = new();
    
    public nuint dwTransferID;
    
    public DDGETTRANSFERSTATUSOUTINFO(nuint value) => this.dwTransferID = value;
    public override string ToString() => $"0x{dwTransferID:x}";
    
    public override readonly bool Equals(object? obj) => obj is DDGETTRANSFERSTATUSOUTINFO value && Equals(value);
    public readonly bool Equals(DDGETTRANSFERSTATUSOUTINFO other) => other.dwTransferID == dwTransferID;
    public override readonly int GetHashCode() => dwTransferID.GetHashCode();
    public static bool operator ==(DDGETTRANSFERSTATUSOUTINFO left, DDGETTRANSFERSTATUSOUTINFO right) => left.Equals(right);
    public static bool operator !=(DDGETTRANSFERSTATUSOUTINFO left, DDGETTRANSFERSTATUSOUTINFO right) => !left.Equals(right);
    public static implicit operator nuint(DDGETTRANSFERSTATUSOUTINFO value) => value.dwTransferID;
    public static implicit operator DDGETTRANSFERSTATUSOUTINFO(nuint value) => new(value);
    
    readonly nuint IValueGet<nuint>.GetValue() => dwTransferID;
    readonly object? IValueGet.GetValue() => dwTransferID;
}
