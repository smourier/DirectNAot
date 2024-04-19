namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicpixelformatinfo2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a9db33a2-af5f-43c7-b679-74f5984b5aa4")]
public partial interface IWICPixelFormatInfo2 : IWICPixelFormatInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpixelformatinfo2-supportstransparency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SupportsTransparency([MarshalAs(UnmanagedType.U4)] out bool pfSupportsTransparency);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpixelformatinfo2-getnumericrepresentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumericRepresentation(out WICPixelFormatNumericRepresentation pNumericRepresentation);
}
