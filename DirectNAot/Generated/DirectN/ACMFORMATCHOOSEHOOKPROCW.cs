namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint ACMFORMATCHOOSEHOOKPROCW(HWND hwnd, uint uMsg, WPARAM wParam, LPARAM lParam);
