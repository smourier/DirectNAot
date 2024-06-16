#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ACMFORMATENUMCBW(HACMDRIVERID hadid, nint pafd, nuint dwInstance, uint fdwSupport);
