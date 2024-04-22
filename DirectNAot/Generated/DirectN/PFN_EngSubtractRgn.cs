namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_EngSubtractRgn(HANDLE hrgnResult, HANDLE hRgnA, HANDLE hRgnB);
