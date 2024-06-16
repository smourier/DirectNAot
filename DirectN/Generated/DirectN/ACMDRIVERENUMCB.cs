#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ACMDRIVERENUMCB(HACMDRIVERID hadid, nuint dwInstance, uint fdwSupport);
