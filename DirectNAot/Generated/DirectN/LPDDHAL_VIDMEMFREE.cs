namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void LPDDHAL_VIDMEMFREE(nint lpDD, int heap, nuint fpMem);
