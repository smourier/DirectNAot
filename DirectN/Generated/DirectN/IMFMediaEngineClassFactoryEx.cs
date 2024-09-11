#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineclassfactoryex
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("c56156c6-ea5b-48a5-9df8-fbe035d0929e")]
public partial interface IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactoryex-createmediasourceextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaSourceExtension(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttr, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSourceExtension>))] out IMFMediaSourceExtension ppMSE);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactoryex-createmediakeys
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMediaKeys(BSTR keySystem, BSTR cdmStorePath, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaKeys>))] out IMFMediaKeys ppKeys);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactoryex-istypesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsTypeSupported(BSTR type, BSTR keySystem, out BOOL isSupported);
}
