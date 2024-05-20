#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool ACMFILTERENUMCBA(HACMDRIVERID hadid, nint pafd, nuint dwInstance, uint fdwSupport);
