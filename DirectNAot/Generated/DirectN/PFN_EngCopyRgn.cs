namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_EngCopyRgn(HANDLE hrgnDst, HANDLE hrgnSrc);
