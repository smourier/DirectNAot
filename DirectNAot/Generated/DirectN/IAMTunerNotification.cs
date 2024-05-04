#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamtunernotification
[GeneratedComInterface, Guid("211a8760-03ac-11d1-8d13-00aa00bd8339")]
public partial interface IAMTunerNotification
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtunernotification-onevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnEvent(AMTunerEventType Event);
}
