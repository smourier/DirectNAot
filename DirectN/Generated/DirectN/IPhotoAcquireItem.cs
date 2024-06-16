#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoacquireitem
[GeneratedComInterface, Guid("00f21c97-28bf-4c02-b842-5e4e90139a30")]
public partial interface IPhotoAcquireItem
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireitem-getitemname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemName(out BSTR pbstrItemName);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireitem-getthumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnail(SIZE sizeThumbnail, out HBITMAP phbmpThumbnail);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireitem-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(in PROPERTYKEY key, out PROPVARIANT pv);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireitem-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(in PROPERTYKEY key, in PROPVARIANT pv);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireitem-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppStream);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireitem-candelete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanDelete(out BOOL pfCanDelete);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireitem-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete();
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireitem-getsubitemcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubItemCount(out uint pnCount);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireitem-getsubitemat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubItemAt(uint nItemIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireItem>))] out IPhotoAcquireItem ppPhotoAcquireItem);
}
