#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D10_CREATE_DEVICE_AND_SWAP_CHAIN1(nint /* IDXGIAdapter */ param0, D3D10_DRIVER_TYPE param1, HMODULE param2, uint param3, D3D10_FEATURE_LEVEL1 param4, uint param5, nint param6, nint param7, nint param8);
