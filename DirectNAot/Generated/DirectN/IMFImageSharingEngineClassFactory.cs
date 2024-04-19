namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/nn-mfsharingengine-imfimagesharingengineclassfactory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("1fc55727-a7fb-4fc8-83ae-8af024990af1")]
public partial interface IMFImageSharingEngineClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-imfimagesharingengineclassfactory-createinstancefromudn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstanceFromUDN(BSTR pUniqueDeviceName, out IMFImageSharingEngine ppEngine);
}
