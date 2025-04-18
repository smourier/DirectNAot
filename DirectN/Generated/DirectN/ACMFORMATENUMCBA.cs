#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ACMFORMATENUMCBA(HACMDRIVERID hadid, nint pafd, nuint dwInstance, uint fdwSupport);
