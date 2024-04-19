namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/nn-mfsharingengine-imfmediasharingengineclassfactory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("524d2bc4-b2b1-4fe5-8fac-fa4e4512b4e0")]
public partial interface IMFMediaSharingEngineClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-imfmediasharingengineclassfactory-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(uint dwFlags, IMFAttributes pAttr, out IMFMediaSharingEngine ppEngine);
}
