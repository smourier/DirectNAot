#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFNProgressNotification(nint pvData, uint uFrameNum, WICProgressOperation operation, double dblProgress);
