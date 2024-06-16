#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL AMGETERRORTEXTPROCW(HRESULT param0, PWSTR param1, uint param2);
