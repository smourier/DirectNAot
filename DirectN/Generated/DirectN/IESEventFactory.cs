#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("506a09b8-7f86-4e04-ac05-3303bfe8fc49")]
public partial interface IESEventFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateESEvent(nint pServiceProvider, uint dwEventId, Guid guidEventType, uint dwEventDataLength, nint /* byte array */ pEventData, BSTR bstrBaseUrl, nint pInitContext, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IESEvent>))] out IESEvent ppESEvent);
}
