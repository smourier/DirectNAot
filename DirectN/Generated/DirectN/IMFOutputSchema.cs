#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfoutputschema
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7be0fc5b-abd9-44fb-a5c8-f50136e71599")]
public partial interface IMFOutputSchema : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfoutputschema-getschematype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSchemaType(out Guid pguidSchemaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfoutputschema-getconfigurationdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConfigurationData(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfoutputschema-getoriginatorid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOriginatorID(out Guid pguidOriginatorID);
}
