#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool ACMFILTERTAGENUMCBA(HACMDRIVERID hadid, nint paftd, nuint dwInstance, uint fdwSupport);
