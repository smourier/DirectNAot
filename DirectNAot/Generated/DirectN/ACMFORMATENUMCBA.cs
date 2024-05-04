#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool ACMFORMATENUMCBA(HACMDRIVERID hadid, nint pafd, nuint dwInstance, uint fdwSupport);
