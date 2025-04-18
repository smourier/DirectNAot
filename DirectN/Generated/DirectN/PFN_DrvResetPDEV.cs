#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvResetPDEV(DHPDEV dhpdevOld, DHPDEV dhpdevNew);
