#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsourceresolver
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fbe5a32d-a497-4b61-bb85-97b1a848a6e3")]
public partial interface IMFSourceResolver
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsourceresolver-createobjectfromurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateObjectFromURL(PWSTR pwszURL, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pProps, out MF_OBJECT_TYPE pObjectType, out nint ppObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsourceresolver-createobjectfrombytestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateObjectFromByteStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pByteStream, PWSTR pwszURL, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pProps, out MF_OBJECT_TYPE pObjectType, out nint ppObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsourceresolver-begincreateobjectfromurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginCreateObjectFromURL(PWSTR pwszURL, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pProps, nint /* optional nint* */ ppIUnknownCancelCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsourceresolver-endcreateobjectfromurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndCreateObjectFromURL([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult, out MF_OBJECT_TYPE pObjectType, out nint ppObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsourceresolver-begincreateobjectfrombytestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginCreateObjectFromByteStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pByteStream, PWSTR pwszURL, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pProps, nint /* optional nint* */ ppIUnknownCancelCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsourceresolver-endcreateobjectfrombytestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndCreateObjectFromByteStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult, out MF_OBJECT_TYPE pObjectType, out nint ppObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsourceresolver-cancelobjectcreation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelObjectCreation(nint pIUnknownCancelCookie);
}
