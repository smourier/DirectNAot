#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("33f2ea09-1398-4ab9-b6a4-f94b49d0a42e")]
public partial interface IFeed2 : IFeed
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemByEffectiveId(int itemEffectiveId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LastItemDownloadTime(out double lastItemDownloadTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Username(out BSTR username);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Password(out BSTR password);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCredentials(BSTR username, BSTR password);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearCredentials();
}
