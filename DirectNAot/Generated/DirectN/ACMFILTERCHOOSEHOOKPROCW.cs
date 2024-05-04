#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint ACMFILTERCHOOSEHOOKPROCW(HWND hwnd, uint uMsg, WPARAM wParam, LPARAM lParam);
