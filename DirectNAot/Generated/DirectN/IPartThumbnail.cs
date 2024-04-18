namespace DirectN;

[GeneratedComInterface, Guid("027ed1c9-ba39-4cc5-aa55-7ec3a0de171a")]
public partial interface IPartThumbnail : IPartBase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetThumbnailProperties(out BSTR pContentType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetThumbnailContent(PWSTR pContentType);
}
