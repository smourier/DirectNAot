#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool AMGETERRORTEXTPROCA(HRESULT param0, PSTR param1, uint param2);
