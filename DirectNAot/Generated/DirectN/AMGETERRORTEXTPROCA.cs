namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool AMGETERRORTEXTPROCA(HRESULT param0, PSTR param1, uint param2);
