#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool ACMFILTERTAGENUMCBW(HACMDRIVERID hadid, nint paftd, nuint dwInstance, uint fdwSupport);
