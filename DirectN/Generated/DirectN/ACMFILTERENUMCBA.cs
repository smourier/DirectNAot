#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ACMFILTERENUMCBA(HACMDRIVERID hadid, nint pafd, nuint dwInstance, uint fdwSupport);
