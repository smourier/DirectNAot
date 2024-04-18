namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPD3DENUMDEVICESCALLBACK7(PSTR lpDeviceDescription, PSTR lpDeviceName, nint param2, nint param3);
