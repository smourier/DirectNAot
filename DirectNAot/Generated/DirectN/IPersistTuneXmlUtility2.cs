#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ipersisttunexmlutility2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("992e165f-ea24-4b2f-9a1d-009d92120451")]
public partial interface IPersistTuneXmlUtility2 : IPersistTuneXmlUtility
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ipersisttunexmlutility2-serialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Serialize(ITuneRequest piTuneRequest, out BSTR pString);
}
