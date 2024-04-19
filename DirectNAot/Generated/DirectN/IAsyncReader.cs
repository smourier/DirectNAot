namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iasyncreader
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868aa-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IAsyncReader
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iasyncreader-requestallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestAllocator(IMemAllocator pPreferred, in ALLOCATOR_PROPERTIES pProps, out IMemAllocator ppActual);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iasyncreader-request
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Request(IMediaSample pSample, nuint dwUser);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iasyncreader-waitfornext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForNext(uint dwTimeout, nint/* nint */ ppSample, out nuint pdwUser);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iasyncreader-syncreadaligned
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SyncReadAligned(IMediaSample pSample);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iasyncreader-syncread
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SyncRead(long llPosition, int lLength, nint /* byte array */ pBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iasyncreader-length
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Length(out long pTotal, out long pAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iasyncreader-beginflush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginFlush();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iasyncreader-endflush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndFlush();
}
