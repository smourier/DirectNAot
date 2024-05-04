#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_Direct3DCreate9On12Ex(uint SDKVersion, nint pOverrideList, uint NumOverrideEntries, nint ppOutputInterface);
