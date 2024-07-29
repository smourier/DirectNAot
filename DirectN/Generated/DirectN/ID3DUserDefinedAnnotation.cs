#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/nn-d3d11_1-id3duserdefinedannotation
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("b2daad8b-03d4-4dbf-95eb-32ab4b63d0ab")]
public partial interface ID3DUserDefinedAnnotation
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3duserdefinedannotation-beginevent
    [PreserveSig]
    int BeginEvent(PWSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3duserdefinedannotation-endevent
    [PreserveSig]
    int EndEvent();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3duserdefinedannotation-setmarker
    [PreserveSig]
    void SetMarker(PWSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3duserdefinedannotation-getstatus
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL GetStatus();
}
