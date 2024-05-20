#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool LPDDENUMCALLBACKA(nint param0, PSTR param1, PSTR param2, nint param3);
