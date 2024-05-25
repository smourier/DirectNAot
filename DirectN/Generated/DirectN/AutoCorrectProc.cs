#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int AutoCorrectProc(ushort langid, PWSTR pszBefore, PWSTR pszAfter, int cchAfter, nint pcchReplaced);
