namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionvisual2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("e8de1639-4331-4b26-bc5f-6a321d347a85")]
public partial interface IDCompositionVisual2 : IDCompositionVisual
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual2-setopacitymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvisual2-setbackfacevisibility
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility);
}
