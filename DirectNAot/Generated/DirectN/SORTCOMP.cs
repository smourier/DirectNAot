namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int SORTCOMP(nint pv1, nint pv2);
