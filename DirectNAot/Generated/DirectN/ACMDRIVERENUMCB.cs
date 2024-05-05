#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool ACMDRIVERENUMCB(HACMDRIVERID hadid, nuint dwInstance, uint fdwSupport);
