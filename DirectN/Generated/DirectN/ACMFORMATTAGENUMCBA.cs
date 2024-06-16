#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ACMFORMATTAGENUMCBA(HACMDRIVERID hadid, nint paftd, nuint dwInstance, uint fdwSupport);
