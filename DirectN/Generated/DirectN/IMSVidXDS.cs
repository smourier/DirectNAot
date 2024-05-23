#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidxds
[GeneratedComInterface, Guid("11ebc158-e712-4d1f-8bb3-01ed5274c4ce")]
public partial interface IMSVidXDS : IMSVidFeature
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidxds-get_channelchangeinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ChannelChangeInterface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint punkCC);
}
