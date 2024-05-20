#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT DxcCreateInstance2Proc(nint /* IMalloc */ pMalloc, nint /* in Guid */ rclsid, nint /* in Guid */ riid, nint ppv);
