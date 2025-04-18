#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ACMFORMATTAGENUMCBW(HACMDRIVERID hadid, nint paftd, nuint dwInstance, uint fdwSupport);
