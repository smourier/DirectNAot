#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("fbb03414-d13b-4786-8319-5ac51fc0a136")]
public partial interface IMFMediaSource2 : IMFMediaSourceEx
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMediaType(uint dwStreamID, IMFMediaType pMediaType);
}
