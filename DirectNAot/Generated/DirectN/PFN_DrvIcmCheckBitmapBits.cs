#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvIcmCheckBitmapBits(DHPDEV param0, HANDLE param1, nint param2, nint param3);
