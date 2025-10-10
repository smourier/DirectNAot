#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ENUMRESNAMEPROCW(HMODULE hModule, PWSTR lpType, PWSTR lpName, nint lParam);
