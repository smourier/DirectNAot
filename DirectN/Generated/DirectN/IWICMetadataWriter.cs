#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwicmetadatawriter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("f7836e16-3be0-470b-86bb-160d0aecd7de")]
public partial interface IWICMetadataWriter : IWICMetadataReader
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatawriter-setvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValue(in PROPVARIANT pvarSchema, in PROPVARIANT pvarId, in PROPVARIANT pvarValue);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatawriter-setvaluebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValueByIndex(uint nIndex, in PROPVARIANT pvarSchema, in PROPVARIANT pvarId, in PROPVARIANT pvarValue);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatawriter-removevalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveValue(in PROPVARIANT pvarSchema, in PROPVARIANT pvarId);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatawriter-removevaluebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveValueByIndex(uint nIndex);
}
