namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvStartDoc(nint pso, PWSTR pwszDocName, uint dwJobId);
