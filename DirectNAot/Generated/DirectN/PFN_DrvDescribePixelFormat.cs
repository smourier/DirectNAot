namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_DrvDescribePixelFormat(DHPDEV param0, int param1, uint param2, nint param3);
