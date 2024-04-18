namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate nint PFNCOMPROPSHEET(HANDLE hComPropSheet, uint Function, LPARAM lParam1, LPARAM lParam2);
