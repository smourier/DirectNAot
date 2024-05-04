#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_EngUnionRgn(HANDLE hrgnResult, HANDLE hRgnA, HANDLE hRgnB);
