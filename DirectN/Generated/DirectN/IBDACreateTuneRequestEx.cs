#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ibdacreatetunerequestex
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c0a4a1d4-2b3c-491a-ba22-499fbadd4d12")]
public partial interface IBDACreateTuneRequestEx
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ibdacreatetunerequestex-createtunerequestex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTuneRequestEx(in Guid TuneRequestIID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuneRequest>))] out ITuneRequest TuneRequest);
}
