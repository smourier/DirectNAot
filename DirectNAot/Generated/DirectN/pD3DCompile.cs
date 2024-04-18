namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT pD3DCompile(nint pSrcData, nuint SrcDataSize, PSTR pFileName, nint /* in D3D_SHADER_MACRO */ pDefines, nint /*  ID3DInclude */ pInclude, PSTR pEntrypoint, PSTR pTarget, uint Flags1, uint Flags2, nint ppCode, nint ppErrorMsgs);
