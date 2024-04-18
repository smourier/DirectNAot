namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1device5
[GeneratedComInterface, Guid("d55ba0a4-6405-4694-aef5-08ee1a4358b4")]
public partial interface ID2D1Device5 : ID2D1Device4
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1device5-createdevicecontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, out ID2D1DeviceContext5 deviceContext5);
}
