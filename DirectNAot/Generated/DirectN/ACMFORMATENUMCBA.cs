#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool ACMFORMATENUMCBA(HACMDRIVERID hadid, nint pafd, nuint dwInstance, uint fdwSupport);
