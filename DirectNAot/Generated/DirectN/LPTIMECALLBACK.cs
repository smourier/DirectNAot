namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void LPTIMECALLBACK(uint uTimerID, uint uMsg, nuint dwUser, nuint dw1, nuint dw2);
