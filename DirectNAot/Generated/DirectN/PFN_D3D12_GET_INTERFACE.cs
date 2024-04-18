namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_D3D12_GET_INTERFACE(nint /* in Guid */ param0, nint /* in Guid */ param1, nint param2);
