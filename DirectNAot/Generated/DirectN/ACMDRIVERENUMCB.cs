#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool ACMDRIVERENUMCB(HACMDRIVERID hadid, nuint dwInstance, uint fdwSupport);
