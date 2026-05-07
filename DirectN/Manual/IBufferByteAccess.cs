namespace DirectN;

[GeneratedComInterface, Guid("905a0fef-bc53-11df-8c49-001e4fc686da")]
public partial interface IBufferByteAccess
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Buffer(out nint buffer);
}
