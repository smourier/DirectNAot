#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate nint PFN_Direct3DCreate9On12(uint SDKVersion, nint pOverrideList, uint NumOverrideEntries);
