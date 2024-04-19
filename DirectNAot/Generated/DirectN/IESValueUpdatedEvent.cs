namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iesvalueupdatedevent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("8a24c46e-bb63-4664-8602-5d9c718c146d")]
public partial interface IESValueUpdatedEvent : IESEvent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesvalueupdatedevent-getvaluenames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueNames(out SAFEARRAY pbstrNames);
}
