#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfoutputpolicy
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7f00f10a-daed-41af-ab26-5fdfa4dfba3c")]
public partial interface IMFOutputPolicy : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfoutputpolicy-generaterequiredschemas
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateRequiredSchemas(uint dwAttributes, Guid guidOutputSubType, in Guid rgGuidProtectionSchemasSupported, uint cProtectionSchemasSupported, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] out IMFCollection ppRequiredProtectionSchemas);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfoutputpolicy-getoriginatorid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOriginatorID(out Guid pguidOriginatorID);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfoutputpolicy-getminimumgrlversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMinimumGRLVersion(out uint pdwMinimumGRLVersion);
}
