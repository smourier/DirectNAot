#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersourceevent2
[GeneratedComInterface, Guid("7aef50ce-8e22-4ba8-bc06-a92a458b4ef2")]
public partial interface IMSVidStreamBufferSourceEvent2 : IMSVidStreamBufferSourceEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersourceevent2-ratechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RateChange(double qwNewRate, double qwOldRate);
}
