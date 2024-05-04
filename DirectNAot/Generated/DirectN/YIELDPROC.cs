#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint YIELDPROC(uint mciId, uint dwYieldData);
