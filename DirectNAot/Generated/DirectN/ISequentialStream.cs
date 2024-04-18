namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-isequentialstream
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d")]
public partial interface ISequentialStream
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-isequentialstream-read
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Read(nint pv, uint cb, nint/* nint */ pcbRead);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-isequentialstream-write
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Write(nint pv, uint cb, nint/* nint */ pcbWritten);
}
