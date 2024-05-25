#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int EDITWORDBREAKPROCEX(PSTR pchText, int cchText, byte bCharSet, int action);
