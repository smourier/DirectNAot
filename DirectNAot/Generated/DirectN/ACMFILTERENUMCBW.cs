#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool ACMFILTERENUMCBW(HACMDRIVERID hadid, nint pafd, nuint dwInstance, uint fdwSupport);
