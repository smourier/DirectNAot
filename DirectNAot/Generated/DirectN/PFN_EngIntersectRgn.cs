#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_EngIntersectRgn(HANDLE hrgnResult, HANDLE hRgnA, HANDLE hRgnB);
