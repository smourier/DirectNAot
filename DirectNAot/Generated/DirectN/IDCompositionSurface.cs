namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionsurface
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("bb8a4953-2c99-4f5a-96f5-4819027fa3ac")]
public partial interface IDCompositionSurface
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurface-begindraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BeginDraw(nint/* nint */ updateRect, in Guid iid, out nint updateObject, out FoundationPOINT updateOffset);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurface-enddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EndDraw();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurface-suspenddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SuspendDraw();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurface-resumedraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ResumeDraw();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurface-scroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Scroll(nint/* nint */ scrollRect, nint/* nint */ clipRect, int offsetX, int offsetY);
}
