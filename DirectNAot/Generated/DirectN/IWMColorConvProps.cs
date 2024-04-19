namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmcolorconvprops
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("e6a49e22-c099-421d-aad3-c061fb4ae85b")]
public partial interface IWMColorConvProps
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcolorconvprops-setmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMode(int lMode);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcolorconvprops-setfullcroppingparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFullCroppingParam(int lSrcCropLeft, int lSrcCropTop, int lDstCropLeft, int lDstCropTop, int lCropWidth, int lCropHeight);
}
