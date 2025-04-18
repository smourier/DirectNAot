#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPBMCALLBACKFN(uint param0, uint param1, LPARAM param2);
