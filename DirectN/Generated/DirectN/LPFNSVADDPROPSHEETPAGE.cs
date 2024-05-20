#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool LPFNSVADDPROPSHEETPAGE(HPROPSHEETPAGE param0, LPARAM param1);
