#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ACMFILTERENUMCBW(HACMDRIVERID hadid, nint pafd, nuint dwInstance, uint fdwSupport);
