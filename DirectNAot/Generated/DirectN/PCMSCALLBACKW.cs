#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PCMSCALLBACKW(nint param0, LPARAM param1);
