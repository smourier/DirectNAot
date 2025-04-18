#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvEndDoc(nint pso, uint fl);
