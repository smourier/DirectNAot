namespace DirectN;

[GeneratedComInterface, Guid("025d1823-6c7d-447b-bbdb-a3cbc3dfa2fc")]
public partial interface IImageBytes
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CountBytes(ref uint pcb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockBytes(uint cb, uint ulOffset, out nint ppvBytes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockBytes(nint pvBytes, uint cb, uint ulOffset);
}
