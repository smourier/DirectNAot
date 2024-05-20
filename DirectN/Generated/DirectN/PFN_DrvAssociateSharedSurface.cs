#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvAssociateSharedSurface(nint param0, HANDLE param1, HANDLE param2, SIZE param3);
