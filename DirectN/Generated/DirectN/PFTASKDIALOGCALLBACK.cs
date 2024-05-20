#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFTASKDIALOGCALLBACK(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam, nint lpRefData);
