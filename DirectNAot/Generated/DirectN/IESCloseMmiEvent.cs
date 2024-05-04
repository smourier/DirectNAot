#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iesclosemmievent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6b80e96f-55e2-45aa-b754-0c23c8e7d5c1")]
public partial interface IESCloseMmiEvent : IESEvent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesclosemmievent-getdialognumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDialogNumber(out uint pDialogNumber);
}
