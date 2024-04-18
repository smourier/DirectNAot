namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D11ON12_CREATE_DEVICE(nint /*  nint */ param0, uint param1, nint/* nint */ param2, uint FeatureLevels, nint /*  nint */ param4, uint NumQueues, uint param6, nint param7, nint param8, nint param9);
