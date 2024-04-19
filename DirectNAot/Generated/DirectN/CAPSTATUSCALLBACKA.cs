namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT CAPSTATUSCALLBACKA(HWND hWnd, int nID, PSTR lpsz);
