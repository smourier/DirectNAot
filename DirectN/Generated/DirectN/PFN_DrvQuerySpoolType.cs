#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvQuerySpoolType(DHPDEV dhpdev, PWSTR pwchType);
