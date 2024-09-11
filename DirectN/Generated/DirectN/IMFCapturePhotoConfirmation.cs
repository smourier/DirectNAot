#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("19f68549-ca8a-4706-a4ef-481dbc95e12c")]
public partial interface IMFCapturePhotoConfirmation
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPhotoConfirmationCallback([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pNotificationCallback);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPixelFormat(Guid subtype);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelFormat(out Guid subtype);
}
