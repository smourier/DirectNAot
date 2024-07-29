#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgiadapter
[GeneratedComInterface, Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0")]
public partial interface IDXGIAdapter : IDXGIObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiadapter-enumoutputs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumOutputs(uint Output, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIOutput>))] out IDXGIOutput ppOutput);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiadapter-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out DXGI_ADAPTER_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiadapter-checkinterfacesupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckInterfaceSupport(in Guid InterfaceName, out long pUMDVersion);
}
