#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwicpersiststream
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("00675040-6908-45f8-86a3-49c7dfd6d9ad")]
public partial interface IWICPersistStream : IPersistStream
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicpersiststream-loadex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadEx(IStream pIStream, in Guid pguidPreferredVendor, uint dwPersistOptions);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicpersiststream-saveex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveEx(IStream pIStream, uint dwPersistOptions, BOOL fClearDirty);
}
