#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_DrvQueryTrueTypeTable(nuint param0, uint param1, uint param2, int param3, uint param4, nint param5, nint param6, nint param7);
