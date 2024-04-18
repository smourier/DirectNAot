namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT LPD3DENUMDEVICESCALLBACK(nint lpGuid, PSTR lpDeviceDescription, PSTR lpDeviceName, nint param3, nint param4, nint param5);
