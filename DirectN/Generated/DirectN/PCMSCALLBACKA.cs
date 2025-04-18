#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PCMSCALLBACKA(nint param0, LPARAM param1);
