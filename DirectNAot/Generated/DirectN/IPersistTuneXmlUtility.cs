namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ipersisttunexmlutility
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("990237ae-ac11-4614-be8f-dd217a4cb4cb")]
public partial interface IPersistTuneXmlUtility
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ipersisttunexmlutility-deserialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Deserialize(VARIANT varValue, out nint ppObject);
}
