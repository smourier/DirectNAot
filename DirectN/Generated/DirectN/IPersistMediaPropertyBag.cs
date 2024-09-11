#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ipersistmediapropertybag
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("5738e040-b67f-11d0-bd4d-00a0c911ce86")]
public partial interface IPersistMediaPropertyBag : IPersist
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipersistmediapropertybag-initnew
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitNew();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipersistmediapropertybag-load
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMediaPropertyBag>))] IMediaPropertyBag pPropBag, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IErrorLog>))] IErrorLog pErrorLog);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipersistmediapropertybag-save
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMediaPropertyBag>))] IMediaPropertyBag pPropBag, BOOL fClearDirty, BOOL fSaveAllProperties);
}
