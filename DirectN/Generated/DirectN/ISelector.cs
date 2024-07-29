#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vidcap/nn-vidcap-iselector
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1abdaeca-68b6-4f83-9371-b413907c7b9f")]
public partial interface ISelector
{
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-iselector-get_numsources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumSources(out uint pdwNumSources);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-iselector-get_sourcenodeid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SourceNodeId(out uint pdwPinId);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-iselector-put_sourcenodeid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SourceNodeId(uint dwPinId);
}
