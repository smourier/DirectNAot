#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwriteremotefontfilestream
[GeneratedComInterface, Guid("4db3757a-2c72-4ed9-b2b6-1ababe1aff9c")]
public partial interface IDWriteRemoteFontFileStream : IDWriteFontFileStream
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteremotefontfilestream-getlocalfilesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocalFileSize(out ulong localFileSize);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteremotefontfilestream-getfilefragmentlocality
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileFragmentLocality(ulong fileOffset, ulong fragmentSize, [MarshalAs(UnmanagedType.U4)] out bool isLocal, ref ulong partialSize);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteremotefontfilestream-getlocality
    [PreserveSig]
    DWRITE_LOCALITY GetLocality();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteremotefontfilestream-begindownload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginDownload(in Guid downloadOperationID, [MarshalUsing(CountElementName = nameof(fragmentCount))] in DWRITE_FILE_FRAGMENT[] fileFragments, uint fragmentCount, out IDWriteAsyncResult asyncResult);
}
