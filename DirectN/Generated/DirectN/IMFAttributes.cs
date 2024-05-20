#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfattributes
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2cd2d921-c447-44a7-a13c-4adabfc247e3")]
public partial interface IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItem(in Guid guidKey, nint /* optional PROPVARIANT* */ pValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getitemtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemType(in Guid guidKey, out MF_ATTRIBUTE_TYPE pType);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-compareitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompareItem(in Guid guidKey, in PROPVARIANT Value, [MarshalAs(UnmanagedType.U4)] out bool pbResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-compare
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Compare(IMFAttributes? pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, [MarshalAs(UnmanagedType.U4)] out bool pbResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getuint32
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUINT32(in Guid guidKey, out uint punValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getuint64
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUINT64(in Guid guidKey, out ulong punValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getdouble
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDouble(in Guid guidKey, out double pfValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGUID(in Guid guidKey, out Guid pguidValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getstringlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringLength(in Guid guidKey, out uint pcchLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetString(in Guid guidKey, [MarshalUsing(CountElementName = nameof(cchBufSize))] PWSTR pwszValue, uint cchBufSize, nint /* optional uint* */ pcchLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getallocatedstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocatedString(in Guid guidKey, out PWSTR ppwszValue, out uint pcchLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getblobsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBlobSize(in Guid guidKey, out uint pcbBlobSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getblob
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBlob(in Guid guidKey, nint /* byte array */ pBuf, uint cbBufSize, nint /* optional uint* */ pcbBlobSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getallocatedblob
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocatedBlob(in Guid guidKey, out nint /* byte array */ ppBuf, out uint pcbSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getunknown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnknown(in Guid guidKey, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-setitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetItem(in Guid guidKey, in PROPVARIANT Value);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-deleteitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteItem(in Guid guidKey);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-deleteallitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteAllItems();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-setuint32
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUINT32(in Guid guidKey, uint unValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-setuint64
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUINT64(in Guid guidKey, ulong unValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-setdouble
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDouble(in Guid guidKey, double fValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-setguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGUID(in Guid guidKey, in Guid guidValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-setstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetString(in Guid guidKey, PWSTR wszValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-setblob
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlob(in Guid guidKey, nint /* byte array */ pBuf, uint cbBufSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-setunknown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnknown(in Guid guidKey, nint pUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-lockstore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockStore();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-unlockstore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockStore();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcItems);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-getitembyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemByIndex(uint unIndex, out Guid pguidKey, nint /* optional PROPVARIANT* */ pValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfattributes-copyallitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyAllItems(IMFAttributes pDest);
}
