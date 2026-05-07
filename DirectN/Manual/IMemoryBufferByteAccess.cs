namespace DirectN;

[GeneratedComInterface, Guid("5b0d3235-4dba-4d44-865e-8f1d0e4fd04d")]
public partial interface IMemoryBufferByteAccess
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(out nint buffer, out uint capacity);
}
