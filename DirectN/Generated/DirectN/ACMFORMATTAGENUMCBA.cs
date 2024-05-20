#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool ACMFORMATTAGENUMCBA(HACMDRIVERID hadid, nint paftd, nuint dwInstance, uint fdwSupport);
