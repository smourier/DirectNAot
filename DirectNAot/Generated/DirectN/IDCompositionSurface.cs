namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionsurface
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("bb8a4953-2c99-4f5a-96f5-4819027fa3ac")]
public partial interface IDCompositionSurface
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurface-begindraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginDraw(nint /* optional FoundationRECT */ updateRect, in Guid iid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ updateObject, out FoundationPOINT updateOffset);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurface-enddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndDraw();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurface-suspenddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SuspendDraw();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurface-resumedraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResumeDraw();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionsurface-scroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Scroll(nint /* optional FoundationRECT */ scrollRect, nint /* optional FoundationRECT */ clipRect, int offsetX, int offsetY);
}
