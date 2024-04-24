namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PD2D1_PROPERTY_SET_FUNCTION(nint /* nint */ effect, nint /* byte array */ data, uint dataSize);
