#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersinkevent4
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1b01dcb0-daf0-412c-a5d1-590c7f62e2b8")]
public partial interface IMSVidStreamBufferSinkEvent4 : IMSVidStreamBufferSinkEvent3
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersinkevent4-writefailureclear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteFailureClear();
}
