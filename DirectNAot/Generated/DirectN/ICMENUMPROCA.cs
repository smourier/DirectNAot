#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int ICMENUMPROCA(PSTR param0, LPARAM param1);
