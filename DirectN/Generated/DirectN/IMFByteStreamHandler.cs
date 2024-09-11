#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfbytestreamhandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("bb420aa4-765b-4a1f-91fe-d6a8a143924c")]
public partial interface IMFByteStreamHandler
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamhandler-begincreateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginCreateObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pByteStream, PWSTR pwszURL, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pProps, nint /* optional nint* */ ppIUnknownCancelCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamhandler-endcreateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndCreateObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult, out MF_OBJECT_TYPE pObjectType, out nint ppObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamhandler-cancelobjectcreation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelObjectCreation(nint pIUnknownCancelCookie);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamhandler-getmaxnumberofbytesrequiredforresolution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxNumberOfBytesRequiredForResolution(out ulong pqwBytes);
}
