namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HANDLE PFN_EngCreateRectRgn(int left, int top, int right, int bottom);
