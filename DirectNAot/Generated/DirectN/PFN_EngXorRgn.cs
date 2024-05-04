#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_EngXorRgn(HANDLE hrgnResult, HANDLE hRgnA, HANDLE hRgnB);
