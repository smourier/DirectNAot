#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint ACMFILTERCHOOSEHOOKPROCA(HWND hwnd, uint uMsg, WPARAM wParam, LPARAM lParam);
