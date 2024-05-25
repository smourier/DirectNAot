#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PCreateTextServices(nint /* nint */ punkOuter, nint /* ITextHost */ pITextHost, nint ppUnk);
