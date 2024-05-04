#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool ACMFORMATTAGENUMCBW(HACMDRIVERID hadid, nint paftd, nuint dwInstance, uint fdwSupport);
