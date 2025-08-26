#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ENUMRESTYPEPROCW(HMODULE hModule, PWSTR lpType, nint lParam);
