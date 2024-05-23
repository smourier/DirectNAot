#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e757b2f5-e73e-434e-a1bf-2bd7c3e60fcb")]
public partial interface IXFeedItem
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Xml(FEEDS_XML_INCLUDE_FLAGS fxif, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream pps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Title(out PWSTR ppszTitle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Link(out PWSTR ppszUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Guid(out PWSTR ppszGuid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Description(out PWSTR ppszDescription);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PubDate(out SYSTEMTIME pstPubDate);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Comments(out PWSTR ppszUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Author(out PWSTR ppszAuthor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enclosure(in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRead([MarshalAs(UnmanagedType.U4)] out bool pbIsRead);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIsRead([MarshalAs(UnmanagedType.U4)] bool bIsRead);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LocalId(out uint puiId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Parent(in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadUrl(out PWSTR ppszUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LastDownloadTime(out SYSTEMTIME pstLastDownloadTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Modified(out SYSTEMTIME pstModifiedTime);
}
