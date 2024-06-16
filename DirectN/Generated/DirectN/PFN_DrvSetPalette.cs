#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvSetPalette(DHPDEV param0, nint param1, uint param2, uint param3, uint param4);
