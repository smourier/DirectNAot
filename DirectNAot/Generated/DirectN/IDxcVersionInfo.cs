namespace DirectN;

[GeneratedComInterface, Guid("b04f5b50-2059-4f12-a8ff-a1e0cde1cc7e")]
public partial interface IDxcVersionInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersion(out uint pMajor, out uint pMinor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out uint pFlags);
}
