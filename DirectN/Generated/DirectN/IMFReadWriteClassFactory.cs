#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/nn-mfreadwrite-imfreadwriteclassfactory
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("e7fe2e12-661c-40da-92f9-4f002ab67627")]
public partial interface IMFReadWriteClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfreadwriteclassfactory-createinstancefromurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstanceFromURL(in Guid clsid, PWSTR pwszURL, IMFAttributes? pAttributes, in Guid riid, out nint /* void */ ppvObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfreadwriteclassfactory-createinstancefromobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstanceFromObject(in Guid clsid, nint punkObject, IMFAttributes? pAttributes, in Guid riid, out nint /* void */ ppvObject);
}
