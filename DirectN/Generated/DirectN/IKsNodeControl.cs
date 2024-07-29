#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vidcap/nn-vidcap-iksnodecontrol
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("11737c14-24a7-4bb5-81a0-0d003813b0c4")]
public partial interface IKsNodeControl
{
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-iksnodecontrol-put_nodeid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_NodeId(uint dwNodeId);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-iksnodecontrol-put_kscontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_KsControl(nint pKsControl);
}
