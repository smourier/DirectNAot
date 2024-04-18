namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D11_CREATE_DEVICE(nint /*  IDXGIAdapter */ param0, D3D_DRIVER_TYPE param1, HMODULE param2, uint param3, nint/* nint */ param4, uint FeatureLevels, uint param6, nint param7, nint param8, nint param9);
