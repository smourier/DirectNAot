namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvAccumulateD3DDirtyRect(nint param0, nint param1);
