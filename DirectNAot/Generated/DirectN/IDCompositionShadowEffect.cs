namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionshadoweffect
[GeneratedComInterface, Guid("4ad18ac0-cfd2-4c2f-bb62-96e54fdb6879")]
public partial interface IDCompositionShadowEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setstandarddeviation(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetStandardDeviation(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setstandarddeviation(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetStandardDeviation(float amount);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetColor(in D2D_VECTOR_4F color);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setred(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRed(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setred(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRed(float amount);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setgreen(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreen(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setgreen(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreen(float amount);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setblue(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlue(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setblue(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlue(float amount);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setalpha(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlpha(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionshadoweffect-setalpha(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlpha(float amount);
}
