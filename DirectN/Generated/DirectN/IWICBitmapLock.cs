#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmaplock
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("00000123-a8f2-4877-ba0a-fd2b6645fb94")]
public partial interface IWICBitmapLock
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmaplock-getsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSize(out uint puiWidth, out uint puiHeight);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmaplock-getstride
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStride(out uint pcbStride);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmaplock-getdatapointer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataPointer(out uint pcbBufferSize, out nint /* byte array */ ppbData);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmaplock-getpixelformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelFormat(out Guid pPixelFormat);
}
