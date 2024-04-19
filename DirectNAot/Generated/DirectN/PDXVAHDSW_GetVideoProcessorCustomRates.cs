namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHDSW_GetVideoProcessorCustomRates(HANDLE hDevice, nint /* in Guid */ pVPGuid, uint Count, nint pRates);
