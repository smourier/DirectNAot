namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1device3
[GeneratedComInterface, Guid("852f2087-802c-4037-ab60-ff2e7ee6fc01")]
public partial interface ID2D1Device3 : ID2D1Device2
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1device3-createdevicecontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, out ID2D1DeviceContext3 deviceContext3);
}
