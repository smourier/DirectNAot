#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvStartDoc(nint pso, PWSTR pwszDocName, uint dwJobId);
