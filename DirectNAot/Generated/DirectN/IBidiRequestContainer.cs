namespace DirectN;

[GeneratedComInterface, Guid("d752f6c0-94a8-4275-a77d-8f1d1a1121ae")]
public partial interface IBidiRequestContainer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddRequest(IBidiRequest pRequest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetEnumObject(out IEnumUnknown ppenum);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRequestCount(out uint puCount);
}
