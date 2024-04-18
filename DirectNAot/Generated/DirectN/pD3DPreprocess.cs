namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT pD3DPreprocess(nint pSrcData, nuint SrcDataSize, PSTR pFileName, nint /* in D3D_SHADER_MACRO */ pDefines, nint /*  ID3DInclude */ pInclude, nint ppCodeText, nint ppErrorMsgs);
