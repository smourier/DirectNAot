namespace DirectN;

[GeneratedComInterface, Guid("725f2e3c-401a-4705-9de0-fe6f1353b87f")]
public partial interface IPartImage : IPartBase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetImageProperties(out BSTR pContentType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetImageContent(PWSTR pContentType);
}
