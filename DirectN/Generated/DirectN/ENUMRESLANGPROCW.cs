#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL ENUMRESLANGPROCW(HMODULE hModule, PWSTR lpType, PWSTR lpName, ushort wLanguage, nint lParam);
