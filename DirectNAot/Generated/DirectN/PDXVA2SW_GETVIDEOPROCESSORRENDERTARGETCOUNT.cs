#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_GETVIDEOPROCESSORRENDERTARGETCOUNT(nint /* in DXVA2_VideoDesc */ pVideoDesc, nint pCount);
