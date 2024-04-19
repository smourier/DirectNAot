namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmresizerprops
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("57665d4c-0414-4faa-905b-10e546f81c33")]
public partial interface IWMResizerProps
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmresizerprops-setresizerquality
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetResizerQuality(int lquality);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmresizerprops-setinterlacemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInterlaceMode(int lmode);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmresizerprops-setclipregion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClipRegion(int lClipOriXSrc, int lClipOriYSrc, int lClipWidthSrc, int lClipHeightSrc);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmresizerprops-setfullcropregion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFullCropRegion(int lClipOriXSrc, int lClipOriYSrc, int lClipWidthSrc, int lClipHeightSrc, int lClipOriXDst, int lClipOriYDst, int lClipWidthDst, int lClipHeightDst);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmresizerprops-getfullcropregion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFullCropRegion(ref int lClipOriXSrc, ref int lClipOriYSrc, ref int lClipWidthSrc, ref int lClipHeightSrc, ref int lClipOriXDst, ref int lClipOriYDst, ref int lClipWidthDst, ref int lClipHeightDst);
}
