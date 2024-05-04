#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate LRESULT LPMMIOPROC(PSTR lpmmioinfo, uint uMsg, LPARAM lParam1, LPARAM lParam2);
