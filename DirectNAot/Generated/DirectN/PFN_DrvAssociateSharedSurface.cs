namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvAssociateSharedSurface(nint param0, HANDLE param1, HANDLE param2, FoundationSIZE param3);
