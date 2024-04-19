namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool ACMFORMATTAGENUMCBA(HACMDRIVERID hadid, nint paftd, nuint dwInstance, uint fdwSupport);
