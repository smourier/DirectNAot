#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richole/nn-richole-iricheditolecallback
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("00020d03-0000-0000-c000-000000000046")]
public partial interface IRichEditOleCallback
{
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditolecallback-getnewstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNewStorage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] out IStorage lplpstg);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditolecallback-getinplacecontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInPlaceContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleInPlaceFrame>))] out IOleInPlaceFrame lplpFrame, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleInPlaceUIWindow>))] out IOleInPlaceUIWindow lplpDoc, ref OLEINPLACEFRAMEINFO lpFrameInfo);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditolecallback-showcontainerui
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowContainerUI([MarshalAs(UnmanagedType.U4)] bool fShow);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditolecallback-queryinsertobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryInsertObject(ref Guid lpclsid, IStorage lpstg, int cp);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditolecallback-deleteobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteObject(IOleObject lpoleobj);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditolecallback-queryacceptdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryAcceptData(IDataObject lpdataobj, ref ushort lpcfFormat, RECO_FLAGS reco, [MarshalAs(UnmanagedType.U4)] bool fReally, HGLOBAL hMetaPict);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditolecallback-contextsensitivehelp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ContextSensitiveHelp([MarshalAs(UnmanagedType.U4)] bool fEnterMode);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditolecallback-getclipboarddata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipboardData(ref CHARRANGE lpchrg, uint reco, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] out IDataObject lplpdataobj);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditolecallback-getdragdropeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDragDropEffect([MarshalAs(UnmanagedType.U4)] bool fDrag, MODIFIERKEYS_FLAGS grfKeyState, ref DROPEFFECT pdwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/richole/nf-richole-iricheditolecallback-getcontextmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContextMenu(RICH_EDIT_GET_CONTEXT_MENU_SEL_TYPE seltype, IOleObject lpoleobj, ref CHARRANGE lpchrg, ref HMENU lphmenu);
}
