﻿#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PDXVA2SW_GETVIDEOPROCESSORSUBSTREAMFORMATCOUNT(nint /* in DXVA2_VideoDesc */ pVideoDesc, D3DFORMAT RenderTargetFormat, nint pCount);
