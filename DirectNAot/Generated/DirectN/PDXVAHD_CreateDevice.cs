namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVAHD_CreateDevice(nint /*  IDirect3DDevice9Ex */ pD3DDevice, nint /* in DXVAHD_CONTENT_DESC */ pContentDesc, DXVAHD_DEVICE_USAGE Usage, nint /*  PDXVAHDSW_Plugin */ pPlugin, nint ppDevice);
