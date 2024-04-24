namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imemallocator
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a8689c-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMemAllocator
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imemallocator-setproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperties(in ALLOCATOR_PROPERTIES pRequest, out ALLOCATOR_PROPERTIES pActual);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imemallocator-getproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperties(out ALLOCATOR_PROPERTIES pProps);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imemallocator-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imemallocator-decommit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Decommit();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imemallocator-getbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(out IMediaSample ppBuffer, nint /* optional long* */ pStartTime, nint /* optional long* */ pEndTime, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imemallocator-releasebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseBuffer(IMediaSample pBuffer);
}
