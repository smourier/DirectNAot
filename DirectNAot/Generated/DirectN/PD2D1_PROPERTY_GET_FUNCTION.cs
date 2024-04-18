namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PD2D1_PROPERTY_GET_FUNCTION(nint /*  nint */ effect, nint data, uint dataSize, nint actualSize);
