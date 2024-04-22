namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_DrvSynchronizeSurface(nint param0, nint param1, uint param2);
