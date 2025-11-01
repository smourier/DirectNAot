#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f5980fed-b521-488f-909f-1a5fcecedb14")]
public partial interface IMFDeviceTransform2 : IMFDeviceTransform
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformAttributes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttributes);
}
