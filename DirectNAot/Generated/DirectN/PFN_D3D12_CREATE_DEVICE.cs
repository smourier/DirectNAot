namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D12_CREATE_DEVICE(nint /*  nint */ param0, D3D_FEATURE_LEVEL param1, nint /* in Guid */ param2, nint param3);
