#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c3fcc19e-a970-11d2-8b5a-00a0c9b7c9c4")]
public partial interface IManagedObject
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSerializedBuffer(out BSTR pBSTR);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectIdentity(out BSTR pBSTRGUID, out int AppDomainID, out int pCCW);
}
