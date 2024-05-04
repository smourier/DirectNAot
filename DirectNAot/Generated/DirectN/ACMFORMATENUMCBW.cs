#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool ACMFORMATENUMCBW(HACMDRIVERID hadid, nint pafd, nuint dwInstance, uint fdwSupport);
