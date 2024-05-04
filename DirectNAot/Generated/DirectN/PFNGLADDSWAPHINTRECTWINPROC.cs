#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFNGLADDSWAPHINTRECTWINPROC(int x, int y, int width, int height);
