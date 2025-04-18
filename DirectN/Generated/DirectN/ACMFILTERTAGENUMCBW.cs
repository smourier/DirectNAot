#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ACMFILTERTAGENUMCBW(HACMDRIVERID hadid, nint paftd, nuint dwInstance, uint fdwSupport);
