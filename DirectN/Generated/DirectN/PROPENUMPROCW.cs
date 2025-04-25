#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PROPENUMPROCW(HWND param0, PWSTR param1, HANDLE param2);
