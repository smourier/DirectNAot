#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ACMFILTERTAGENUMCBA(HACMDRIVERID hadid, nint paftd, nuint dwInstance, uint fdwSupport);
