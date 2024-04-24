namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_CREATEVIDEOPROCESSDEVICE(nint /* IDirect3DDevice9 */ pD3DD9, nint /* in DXVA2_VideoDesc */ pVideoDesc, D3DFORMAT RenderTargetFormat, uint MaxSubStreams, nint phDevice);
