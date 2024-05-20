#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool AMGETERRORTEXTPROCW(HRESULT param0, PWSTR param1, uint param2);
