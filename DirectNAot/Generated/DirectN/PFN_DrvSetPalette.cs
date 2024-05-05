#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvSetPalette(DHPDEV param0, nint param1, uint param2, uint param3, uint param4);
