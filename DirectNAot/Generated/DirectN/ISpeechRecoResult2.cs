#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8e0a246d-d3c8-45de-8657-04290c458c3c")]
public partial interface ISpeechRecoResult2 : ISpeechRecoResult
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextFeedback(BSTR Feedback, VARIANT_BOOL WasSuccessful);
}
