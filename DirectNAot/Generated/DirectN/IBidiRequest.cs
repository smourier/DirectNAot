namespace DirectN;

[GeneratedComInterface, Guid("8f348bd7-4b47-4755-8a9d-0f422df3dc89")]
public partial interface IBidiRequest
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSchema(PWSTR pszSchema);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetInputData(uint dwType, nint /* byte array */ pData, uint uSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetResult([MarshalAs(UnmanagedType.Error)] out HRESULT phr);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOutputData(uint dwIndex, out PWSTR ppszSchema, out uint pdwType, out nint /* byte array */ ppData, out uint uSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetEnumCount(out uint pdwTotal);
}
