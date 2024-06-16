#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrvideostreamcontrol
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("058d1f11-2a54-4bef-bd54-df706626b727")]
public partial interface IVMRVideoStreamControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrvideostreamcontrol-setcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorKey(in DDCOLORKEY lpClrKey);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrvideostreamcontrol-getcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorKey(out DDCOLORKEY lpClrKey);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrvideostreamcontrol-setstreamactivestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamActiveState(BOOL fActive);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrvideostreamcontrol-getstreamactivestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamActiveState(out BOOL lpfActive);
}
