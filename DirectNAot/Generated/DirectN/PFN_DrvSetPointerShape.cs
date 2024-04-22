namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_DrvSetPointerShape(nint param0, nint param1, nint param2, nint param3, int param4, int param5, int param6, int param7, nint param8, uint param9);
