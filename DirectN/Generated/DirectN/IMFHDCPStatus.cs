#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("de400f54-5bf1-40cf-8964-0bea136b1e3d")]
public partial interface IMFHDCPStatus
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Query(ref MF_HDCP_STATUS pStatus, ref BOOL pfStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Set(MF_HDCP_STATUS status);
}
