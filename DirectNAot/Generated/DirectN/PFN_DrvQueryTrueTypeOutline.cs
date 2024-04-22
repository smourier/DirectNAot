namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_DrvQueryTrueTypeOutline(DHPDEV param0, nint param1, uint param2, [MarshalAs(UnmanagedType.U4)] bool param3, nint param4, uint param5, nint param6);
