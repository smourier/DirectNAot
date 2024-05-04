#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT DxcCreateInstanceProc(nint /* in Guid */ rclsid, nint /* in Guid */ riid, nint ppv);
