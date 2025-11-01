#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ddd59578-d0e7-46e2-be8c-1ce76ad147c0")]
public partial interface IMFFaceDetectionTransform
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDetectionCallback([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFFaceDetectionTransformCallback>))] IMFFaceDetectionTransformCallback callback, out nint callbackToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearDetectionCallback(nint callbackToken);
}
