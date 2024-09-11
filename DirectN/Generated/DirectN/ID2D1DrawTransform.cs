#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1drawtransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("36bfdcb6-9739-435d-a30d-a653beff6a6f")]
public partial interface ID2D1DrawTransform : ID2D1Transform
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1drawtransform-setdrawinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDrawInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DrawInfo>))] ID2D1DrawInfo drawInfo);
}
