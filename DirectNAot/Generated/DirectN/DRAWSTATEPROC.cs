namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool DRAWSTATEPROC(HDC hdc, LPARAM lData, WPARAM wData, int cx, int cy);
