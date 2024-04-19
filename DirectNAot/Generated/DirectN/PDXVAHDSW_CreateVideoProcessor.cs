namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_CreateVideoProcessor(HANDLE hDevice, nint /* in Guid */ pVPGuid, nint phVideoProcessor);
