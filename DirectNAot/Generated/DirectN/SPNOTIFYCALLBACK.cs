namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void SPNOTIFYCALLBACK(WPARAM wParam, LPARAM lParam);
