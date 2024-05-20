#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint ACMFORMATCHOOSEHOOKPROCA(HWND hwnd, uint uMsg, WPARAM wParam, LPARAM lParam);
