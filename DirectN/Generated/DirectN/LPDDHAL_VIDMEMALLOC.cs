#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate nuint LPDDHAL_VIDMEMALLOC(nint lpDD, int heap, uint dwWidth, uint dwHeight);
