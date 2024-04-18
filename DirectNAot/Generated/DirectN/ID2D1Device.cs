﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1device
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("47dd575d-ac05-4cdd-8049-9b02cd16f44c")]
public partial interface ID2D1Device : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1device-createdevicecontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, out ID2D1DeviceContext deviceContext);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1device-createprintcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreatePrintControl(IWICImagingFactory wicFactory, IPrintDocumentPackageTarget documentTarget, nint /* D2D1_PRINT_CONTROL_PROPERTIES */ printControlProperties, out ID2D1PrintControl printControl);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1device-setmaximumtexturememory
    [PreserveSig]
    public void SetMaximumTextureMemory(ulong maximumInBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1device-getmaximumtexturememory
    [PreserveSig]
    public ulong GetMaximumTextureMemory();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1device-clearresources
    [PreserveSig]
    public void ClearResources(uint millisecondsSinceUse);
}
