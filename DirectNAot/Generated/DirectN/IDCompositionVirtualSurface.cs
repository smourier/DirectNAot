namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionvirtualsurface
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("ae471c51-5f53-4a24-8d3e-d0c39c30b3f0")]
public partial interface IDCompositionVirtualSurface : IDCompositionSurface
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvirtualsurface-resize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resize(uint width, uint height);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionvirtualsurface-trim
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Trim(nint /* optional FoundationRECT* */ rectangles, uint count);
}
