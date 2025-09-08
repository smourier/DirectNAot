#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_set_hdcp_srm_parameters
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct OPM_SET_HDCP_SRM_PARAMETERS : IEquatable<OPM_SET_HDCP_SRM_PARAMETERS>, IValueGet<uint>
{
    public static readonly OPM_SET_HDCP_SRM_PARAMETERS Null = new();
    
    public uint ulSRMVersion;
    
    public OPM_SET_HDCP_SRM_PARAMETERS(uint value) => this.ulSRMVersion = value;
    public override readonly string ToString() => $"0x{ulSRMVersion:x}";
    
    public override readonly bool Equals(object? obj) => obj is OPM_SET_HDCP_SRM_PARAMETERS value && Equals(value);
    public readonly bool Equals(OPM_SET_HDCP_SRM_PARAMETERS other) => other.ulSRMVersion == ulSRMVersion;
    public override readonly int GetHashCode() => ulSRMVersion.GetHashCode();
    public static bool operator ==(OPM_SET_HDCP_SRM_PARAMETERS left, OPM_SET_HDCP_SRM_PARAMETERS right) => left.Equals(right);
    public static bool operator !=(OPM_SET_HDCP_SRM_PARAMETERS left, OPM_SET_HDCP_SRM_PARAMETERS right) => !left.Equals(right);
    public static implicit operator uint(OPM_SET_HDCP_SRM_PARAMETERS value) => value.ulSRMVersion;
    public static implicit operator OPM_SET_HDCP_SRM_PARAMETERS(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => ulSRMVersion;
    readonly object? IValueGet.GetValue() => ulSRMVersion;
}
