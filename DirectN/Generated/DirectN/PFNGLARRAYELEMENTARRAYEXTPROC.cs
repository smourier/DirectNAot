#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLARRAYELEMENTARRAYEXTPROC(uint mode, int count, nint pi);
