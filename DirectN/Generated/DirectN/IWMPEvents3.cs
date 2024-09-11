#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpevents3
[GeneratedComInterface, Guid("1f504270-a66b-4223-8e96-26a06c63d69f")]
public partial interface IWMPEvents3 : IWMPEvents2
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-cdromripstatechange
    [PreserveSig]
    void CdromRipStateChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPCdromRip>))] IWMPCdromRip pCdromRip, WMPRipState wmprs);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-cdromripmediaerror
    [PreserveSig]
    void CdromRipMediaError([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPCdromRip>))] IWMPCdromRip pCdromRip, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch pMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-cdromburnstatechange
    [PreserveSig]
    void CdromBurnStateChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPCdromBurn>))] IWMPCdromBurn pCdromBurn, WMPBurnState wmpbs);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-cdromburnmediaerror
    [PreserveSig]
    void CdromBurnMediaError([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPCdromBurn>))] IWMPCdromBurn pCdromBurn, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch pMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-cdromburnerror
    [PreserveSig]
    void CdromBurnError([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPCdromBurn>))] IWMPCdromBurn pCdromBurn, HRESULT hrError);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-libraryconnect
    [PreserveSig]
    void LibraryConnect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPLibrary>))] IWMPLibrary pLibrary);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-librarydisconnect
    [PreserveSig]
    void LibraryDisconnect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPLibrary>))] IWMPLibrary pLibrary);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-folderscanstatechange
    [PreserveSig]
    void FolderScanStateChange(WMPFolderScanState wmpfss);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-stringcollectionchange
    [PreserveSig]
    void StringCollectionChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch pdispStringCollection, WMPStringCollectionChangeEventType change, int lCollectionIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-mediacollectionmediaadded
    [PreserveSig]
    void MediaCollectionMediaAdded([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch pdispMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents3-mediacollectionmediaremoved
    [PreserveSig]
    void MediaCollectionMediaRemoved([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch pdispMedia);
}
