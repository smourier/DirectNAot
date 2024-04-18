namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvUpdateUISetting(nint pdriverobj, nint pOptItem, uint dwPreviousSelection, uint dwMode);
