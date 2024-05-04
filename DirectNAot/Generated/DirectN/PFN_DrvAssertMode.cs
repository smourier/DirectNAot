#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvAssertMode(DHPDEV param0, [MarshalAs(UnmanagedType.U4)] bool param1);
