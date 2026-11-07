#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D12_COMPILER_GET_INTERFACE(nint /* in Guid */ rclsid, nint /* in Guid */ riid, nint ppvIface);
