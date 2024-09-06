#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontfilestream
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0")]
public partial interface IDWriteFontFileStream
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfilestream-readfilefragment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadFileFragment(out nint fragmentStart, ulong fileOffset, ulong fragmentSize, out nint fragmentContext);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfilestream-releasefilefragment
    [PreserveSig]
    void ReleaseFileFragment(nint fragmentContext);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfilestream-getfilesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileSize(out ulong fileSize);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfilestream-getlastwritetime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastWriteTime(out ulong lastWriteTime);
}
