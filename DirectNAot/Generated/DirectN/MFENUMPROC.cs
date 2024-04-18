namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int MFENUMPROC(HDC hdc, nint /* in HANDLETABLE */ lpht, nint /* in METARECORD */ lpMR, int nObj, LPARAM param4);
