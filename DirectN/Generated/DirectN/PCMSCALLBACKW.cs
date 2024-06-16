#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PCMSCALLBACKW(nint param0, LPARAM param1);
