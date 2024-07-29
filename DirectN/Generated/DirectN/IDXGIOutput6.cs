#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_6/nn-dxgi1_6-idxgioutput6
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("068346e8-aaec-4b84-add7-137f513f77a1")]
public partial interface IDXGIOutput6 : IDXGIOutput5
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-idxgioutput6-getdesc1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc1(out DXGI_OUTPUT_DESC1 pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-idxgioutput6-checkhardwarecompositionsupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckHardwareCompositionSupport(out uint pFlags);
}
