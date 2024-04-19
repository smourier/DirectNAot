namespace DirectN;

[GeneratedComInterface, Guid("14eecffc-4df8-40f7-a118-5c816f45695e")]
public partial interface ID3D12Device13 : ID3D12Device12
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenExistingHeapFromAddress1(nint pAddress, nuint size, in Guid riid, out nint ppvHeap);
}
