#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HBITMAP PFN_DrvCreateDeviceBitmap(DHPDEV param0, SIZE param1, uint param2);
