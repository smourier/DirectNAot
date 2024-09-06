#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersink2
[GeneratedComInterface, Guid("2ca9fc63-c131-4e5a-955a-544a47c67146")]
public partial interface IMSVidStreamBufferSink2 : IMSVidStreamBufferSink
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink2-unlockprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockProfile();
}
