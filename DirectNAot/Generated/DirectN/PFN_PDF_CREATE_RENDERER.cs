namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HRESULT PFN_PDF_CREATE_RENDERER(nint /*  IDXGIDevice */ param0, nint param1);
