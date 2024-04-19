namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrdeinterlacecontrol
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("bb057577-0db8-4e6a-87a7-1a8c9a505a0f")]
public partial interface IVMRDeinterlaceControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrdeinterlacecontrol-getnumberofdeinterlacemodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfDeinterlaceModes(in VMRVideoDesc lpVideoDescription, ref uint lpdwNumDeinterlaceModes, out Guid lpDeinterlaceModes);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrdeinterlacecontrol-getdeinterlacemodecaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeinterlaceModeCaps(in Guid lpDeinterlaceMode, in VMRVideoDesc lpVideoDescription, ref VMRDeinterlaceCaps lpDeinterlaceCaps);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrdeinterlacecontrol-getdeinterlacemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeinterlaceMode(uint dwStreamID, out Guid lpDeinterlaceMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrdeinterlacecontrol-setdeinterlacemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeinterlaceMode(uint dwStreamID, in Guid lpDeinterlaceMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrdeinterlacecontrol-getdeinterlaceprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeinterlacePrefs(out uint lpdwDeinterlacePrefs);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrdeinterlacecontrol-setdeinterlaceprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeinterlacePrefs(uint dwDeinterlacePrefs);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrdeinterlacecontrol-getactualdeinterlacemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActualDeinterlaceMode(uint dwStreamID, out Guid lpDeinterlaceMode);
}
