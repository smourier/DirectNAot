#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_CreateDevice(nint /* IDirect3DDevice9Ex */ pD3DDevice, nint phDevice);
