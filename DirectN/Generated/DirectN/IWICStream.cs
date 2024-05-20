#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicstream
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("135ff860-22b7-4ddf-b0f6-218f4f299a43")]
public partial interface IWICStream : IStream
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicstream-initializefromistream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromIStream(IStream pIStream);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicstream-initializefromfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromFilename(PWSTR wzFileName, uint dwDesiredAccess);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicstream-initializefrommemory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromMemory(nint /* byte array */ pbBuffer, uint cbBufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicstream-initializefromistreamregion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromIStreamRegion(IStream pIStream, ulong ulOffset, ulong ulMaxSize);
}
