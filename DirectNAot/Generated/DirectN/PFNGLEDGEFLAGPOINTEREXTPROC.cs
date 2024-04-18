namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLEDGEFLAGPOINTEREXTPROC(int stride, int count, nint /* byte array */ pointer);
