#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL AMGETERRORTEXTPROCA(HRESULT param0, PSTR param1, uint param2);
