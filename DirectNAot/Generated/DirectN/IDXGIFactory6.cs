namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_6/nn-dxgi1_6-idxgifactory6
[SupportedOSPlatform("windows10.0.17134")]
[GeneratedComInterface, Guid("c1b6694f-ff09-44a9-b03c-77900a0a1d17")]
public partial interface IDXGIFactory6 : IDXGIFactory5
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-idxgifactory6-enumadapterbygpupreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAdapterByGpuPreference(uint Adapter, DXGI_GPU_PREFERENCE GpuPreference, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvAdapter);
}
