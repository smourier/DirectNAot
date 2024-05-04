#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1device6
[GeneratedComInterface, Guid("7bfef914-2d75-4bad-be87-e18ddb077b6d")]
public partial interface ID2D1Device6 : ID2D1Device5
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1device6-createdevicecontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, out ID2D1DeviceContext6 deviceContext6);
}
