namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11on12/nn-d3d11on12-id3d11on12device1
[SupportedOSPlatform("windows10.0.18362")]
[GeneratedComInterface, Guid("bdb64df4-ea2f-4c70-b861-aaab1258bb5d")]
public partial interface ID3D11On12Device1 : ID3D11On12Device
{
    // https://learn.microsoft.com/windows/win32/api/d3d11on12/nf-d3d11on12-id3d11on12device1-getd3d12device
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetD3D12Device(in Guid riid, out nint ppvDevice);
}
