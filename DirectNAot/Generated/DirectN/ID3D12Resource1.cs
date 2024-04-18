namespace DirectN;

[GeneratedComInterface, Guid("9d5e227a-4430-4161-88b3-3eca6bb16e19")]
public partial interface ID3D12Resource1 : ID3D12Resource
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetProtectedResourceSession(in Guid riid, nint/* nint */ ppProtectedSession);
}
