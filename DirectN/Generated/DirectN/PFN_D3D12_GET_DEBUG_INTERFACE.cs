#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D12_GET_DEBUG_INTERFACE(nint /* in Guid */ param0, nint param1);
