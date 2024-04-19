namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT CAPERRORCALLBACKA(HWND hWnd, int nID, PSTR lpsz);
