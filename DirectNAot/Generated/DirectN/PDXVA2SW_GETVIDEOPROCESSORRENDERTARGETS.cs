namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_GETVIDEOPROCESSORRENDERTARGETS(nint /* in DXVA2_VideoDesc */ pVideoDesc, uint Count, nint pFormats);
