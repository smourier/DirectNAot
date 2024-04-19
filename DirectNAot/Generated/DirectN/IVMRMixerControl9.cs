namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrmixercontrol9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1a777eaa-47c8-4930-b2c9-8fee1c1b0f3b")]
public partial interface IVMRMixerControl9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-setalpha
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlpha(uint dwStreamID, float Alpha);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-getalpha
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlpha(uint dwStreamID, out float pAlpha);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-setzorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetZOrder(uint dwStreamID, uint dwZ);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-getzorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetZOrder(uint dwStreamID, out uint pZ);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-setoutputrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputRect(uint dwStreamID, in VMR9NormalizedRect pRect);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-getoutputrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputRect(uint dwStreamID, out VMR9NormalizedRect pRect);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-setbackgroundclr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackgroundClr(COLORREF ClrBkg);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-getbackgroundclr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackgroundClr(in COLORREF lpClrBkg);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-setmixingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMixingPrefs(uint dwMixerPrefs);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-getmixingprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMixingPrefs(out uint pdwMixerPrefs);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-setprocampcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProcAmpControl(uint dwStreamID, in VMR9ProcAmpControl lpClrControl);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-getprocampcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcAmpControl(uint dwStreamID, ref VMR9ProcAmpControl lpClrControl);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrmixercontrol9-getprocampcontrolrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcAmpControlRange(uint dwStreamID, ref VMR9ProcAmpControlRange lpClrControl);
}
