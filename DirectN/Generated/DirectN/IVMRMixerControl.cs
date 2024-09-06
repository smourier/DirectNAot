#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrmixercontrol
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1c1a17b0-bed0-415d-974b-dc6696131599")]
public partial interface IVMRMixerControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixercontrol-setalpha
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlpha(uint dwStreamID, float Alpha);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixercontrol-getalpha
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlpha(uint dwStreamID, out float pAlpha);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixercontrol-setzorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetZOrder(uint dwStreamID, uint dwZ);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixercontrol-getzorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetZOrder(uint dwStreamID, out uint pZ);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixercontrol-setoutputrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputRect(uint dwStreamID, in NORMALIZEDRECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixercontrol-getoutputrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputRect(uint dwStreamID, out NORMALIZEDRECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixercontrol-setbackgroundclr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackgroundClr(COLORREF ClrBkg);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixercontrol-getbackgroundclr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackgroundClr(in COLORREF lpClrBkg);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixercontrol-setmixingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMixingPrefs(uint dwMixerPrefs);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrmixercontrol-getmixingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMixingPrefs(out uint pdwMixerPrefs);
}
