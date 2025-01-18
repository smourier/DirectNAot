#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("929bb1aa-725f-433b-abd7-273075a835f2")]
public partial interface IDCompositionTexture
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceRect(in D2D_RECT_U sourceRect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaMode(DXGI_ALPHA_MODE alphaMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableFence(out ulong fenceValue, in Guid iid, out nint /* void */ availableFence);
}
