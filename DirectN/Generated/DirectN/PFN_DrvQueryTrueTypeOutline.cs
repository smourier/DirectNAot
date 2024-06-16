#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_DrvQueryTrueTypeOutline(DHPDEV param0, nint param1, uint param2, BOOL param3, nint param4, uint param5, nint param6);
