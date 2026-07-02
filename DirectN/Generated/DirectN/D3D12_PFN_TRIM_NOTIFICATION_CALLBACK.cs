#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void D3D12_PFN_TRIM_NOTIFICATION_CALLBACK(nint /* in D3D12_TRIM_NOTIFICATION */ __MIDL____MIDL_itf_d3d12_0000_00640000);
