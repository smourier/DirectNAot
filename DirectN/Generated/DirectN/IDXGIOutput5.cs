#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_5/nn-dxgi1_5-idxgioutput5
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("80a07424-ab52-42eb-833c-0c42fd282d98")]
public partial interface IDXGIOutput5 : IDXGIOutput4
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_5/nf-dxgi1_5-idxgioutput5-duplicateoutput1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DuplicateOutput1(nint pDevice, uint Flags, uint SupportedFormatsCount, [In][MarshalUsing(CountElementName = nameof(SupportedFormatsCount))] DXGI_FORMAT[] pSupportedFormats, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIOutputDuplication>))] out IDXGIOutputDuplication ppOutputDuplication);
}
