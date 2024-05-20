#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool LPDDHEL_INIT(nint param0, [MarshalAs(UnmanagedType.U4)] bool param1);
