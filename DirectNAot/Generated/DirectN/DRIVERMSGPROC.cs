namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint DRIVERMSGPROC(uint param0, uint param1, nuint param2, nuint param3, nuint param4);
