namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT pD3DDisassemble(nint pSrcData, nuint SrcDataSize, uint Flags, PSTR? szComments, nint ppDisassembly);
