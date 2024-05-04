#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D11ON12_CREATE_DEVICE(nint /* nint */ param0, uint param1, nint /* optional D3D_FEATURE_LEVEL* */ param2, uint FeatureLevels, nint /* optional nint* */ param4, uint NumQueues, uint param6, nint param7, nint param8, nint param9);
