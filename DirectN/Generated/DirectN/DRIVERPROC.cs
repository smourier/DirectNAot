#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT DRIVERPROC(nuint param0, HDRVR param1, uint param2, LPARAM param3, LPARAM param4);
