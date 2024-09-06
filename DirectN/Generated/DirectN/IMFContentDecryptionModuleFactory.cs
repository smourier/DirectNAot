#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nn-mfcontentdecryptionmodule-imfcontentdecryptionmodulefactory
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("7d5abf16-4cbb-4e08-b977-9ba59049943e")]
public partial interface IMFContentDecryptionModuleFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodulefactory-istypesupported
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsTypeSupported(PWSTR keySystem, PWSTR contentType);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodulefactory-createcontentdecryptionmoduleaccess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateContentDecryptionModuleAccess(PWSTR keySystem, [In][MarshalUsing(CountElementName = nameof(numConfigurations))] IPropertyStore[] configurations, uint numConfigurations, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFContentDecryptionModuleAccess>))] out IMFContentDecryptionModuleAccess contentDecryptionModuleAccess);
}
