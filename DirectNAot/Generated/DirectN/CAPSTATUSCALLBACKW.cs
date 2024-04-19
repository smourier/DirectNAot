namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT CAPSTATUSCALLBACKW(HWND hWnd, int nID, PWSTR lpsz);
