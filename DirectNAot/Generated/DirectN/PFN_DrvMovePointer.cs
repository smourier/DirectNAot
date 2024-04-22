namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_DrvMovePointer(nint pso, int x, int y, nint prcl);
