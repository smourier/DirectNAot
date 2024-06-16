#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvAssociateSharedSurface(nint param0, HANDLE param1, HANDLE param2, SIZE param3);
