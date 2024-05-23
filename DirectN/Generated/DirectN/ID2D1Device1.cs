#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_2/nn-d2d1_2-id2d1device1
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("d21768e1-23a4-4823-a14b-7c3eba85d658")]
public partial interface ID2D1Device1 : ID2D1Device
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_2/nf-d2d1_2-id2d1device1-getrenderingpriority
    [PreserveSig]
    D2D1_RENDERING_PRIORITY GetRenderingPriority();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_2/nf-d2d1_2-id2d1device1-setrenderingpriority
    [PreserveSig]
    void SetRenderingPriority(D2D1_RENDERING_PRIORITY renderingPriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DeviceContext1>))] out ID2D1DeviceContext1 deviceContext1);
}
