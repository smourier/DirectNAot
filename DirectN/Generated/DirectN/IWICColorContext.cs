#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwiccolorcontext
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3c613a02-34b2-44ea-9a7c-45aea9c6fd6d")]
public partial interface IWICColorContext
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccolorcontext-initializefromfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromFilename(PWSTR wzFilename);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccolorcontext-initializefrommemory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromMemory(nint /* byte array */ pbBuffer, uint cbBufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccolorcontext-initializefromexifcolorspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromExifColorSpace(uint value);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccolorcontext-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out WICColorContextType pType);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccolorcontext-getprofilebytes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProfileBytes(uint cbBuffer, nint /* byte array */ pbBuffer, out uint pcbActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccolorcontext-getexifcolorspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExifColorSpace(out uint pValue);
}
