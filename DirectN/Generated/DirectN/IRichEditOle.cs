#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richole/nn-richole-iricheditole
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("00020d00-0000-0000-c000-000000000046")]
public partial interface IRichEditOle
{
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-getclientsite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClientSite([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleClientSite>))] out IOleClientSite lplpolesite);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-getobjectcount
    [PreserveSig]
    int GetObjectCount();
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-getlinkcount
    [PreserveSig]
    int GetLinkCount();
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-getobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObject(int iob, ref REOBJECT lpreobject, RICH_EDIT_GET_OBJECT_FLAGS dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-insertobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertObject(ref REOBJECT lpreobject);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-convertobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertObject(int iob, in Guid rclsidNew, PSTR lpstrUserTypeNew);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-activateas
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateAs(in Guid rclsid, in Guid rclsidAs);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-sethostnames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHostNames(PSTR lpstrContainerApp, PSTR lpstrContainerObj);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-setlinkavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLinkAvailable(int iob, [MarshalAs(UnmanagedType.U4)] bool fAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-setdvaspect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDvaspect(int iob, uint dvaspect);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-handsoffstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HandsOffStorage(int iob);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-savecompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveCompleted(int iob, IStorage lpstg);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-inplacedeactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InPlaceDeactivate();
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-contextsensitivehelp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ContextSensitiveHelp([MarshalAs(UnmanagedType.U4)] bool fEnterMode);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-getclipboarddata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipboardData(ref CHARRANGE lpchrg, uint reco, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] out IDataObject lplpdataobj);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditole-importdataobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ImportDataObject(IDataObject lpdataobj, ushort cf, HGLOBAL hMetaPict);
}
