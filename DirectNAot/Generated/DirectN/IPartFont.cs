namespace DirectN;

[GeneratedComInterface, Guid("e07fe0ab-1124-43d0-a865-e8ffb6a3ea82")]
public partial interface IPartFont : IPartBase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontProperties(out BSTR pContentType, out EXpsFontOptions pFontOptions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFontContent(PWSTR pContentType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFontOptions(EXpsFontOptions options);
}
