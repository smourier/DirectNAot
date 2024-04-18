namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int ENHMFENUMPROC(HDC hdc, nint /* in HANDLETABLE */ lpht, nint /* in ENHMETARECORD */ lpmr, int nHandles, LPARAM data);
