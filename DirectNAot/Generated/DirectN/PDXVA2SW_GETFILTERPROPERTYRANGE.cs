namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_GETFILTERPROPERTYRANGE(nint /* in DXVA2_VideoDesc */ pVideoDesc, D3DFORMAT RenderTargetFormat, uint FilterSetting, nint pRange);
