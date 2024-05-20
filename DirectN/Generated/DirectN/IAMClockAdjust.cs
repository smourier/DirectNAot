#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamclockadjust
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("4d5466b0-a49c-11d1-abe8-00a0c905f375")]
public partial interface IAMClockAdjust
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamclockadjust-setclockdelta
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClockDelta(long rtDelta);
}
