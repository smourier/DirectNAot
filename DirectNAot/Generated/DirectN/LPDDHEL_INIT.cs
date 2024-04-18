namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool LPDDHEL_INIT(nint param0, [MarshalAs(UnmanagedType.U4)] bool param1);
