#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvResetPDEV(DHPDEV dhpdevOld, DHPDEV dhpdevNew);
