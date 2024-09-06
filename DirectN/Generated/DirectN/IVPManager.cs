#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivpmanager
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("aac18c18-e186-46d2-825d-a1f8dc8e395a")]
public partial interface IVPManager
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivpmanager-setvideoportindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoPortIndex(uint dwVideoPortIndex);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivpmanager-getvideoportindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoPortIndex(out uint pdwVideoPortIndex);
}
