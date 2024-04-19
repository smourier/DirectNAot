namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT LPACMDRIVERPROC(nuint param0, HACMDRIVERID param1, uint param2, LPARAM param3, LPARAM param4);
