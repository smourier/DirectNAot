#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_DESTROYVIDEOPROCESSDEVICE(HANDLE hDevice);
