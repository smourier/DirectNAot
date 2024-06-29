#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/nn-mfsharingengine-imfsharingengineclassfactory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("2ba61f92-8305-413b-9733-faf15f259384")]
public partial interface IMFSharingEngineClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-imfsharingengineclassfactory-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(uint dwFlags, IMFAttributes? pAttr, out nint ppEngine);
}
