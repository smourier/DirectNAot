#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_DrvQueryTrueTypeSection(uint param0, uint param1, uint param2, nint param3, nint param4);
