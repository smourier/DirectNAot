#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1device2
[GeneratedComInterface, Guid("a44472e1-8dfb-4e60-8492-6e2861c9ca8b")]
public partial interface ID2D1Device2 : ID2D1Device1
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1device2-createdevicecontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DeviceContext2>))] out ID2D1DeviceContext2 deviceContext2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1device2-flushdevicecontexts
    [PreserveSig]
    void FlushDeviceContexts([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Bitmap>))] ID2D1Bitmap bitmap);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1device2-getdxgidevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDxgiDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIDevice>))] out IDXGIDevice dxgiDevice);
}
