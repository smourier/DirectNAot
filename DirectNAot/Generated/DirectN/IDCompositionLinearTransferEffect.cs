namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionlineartransfereffect
[GeneratedComInterface, Guid("4305ee5b-c4a0-4c88-9385-67124e017683")]
public partial interface IDCompositionLinearTransferEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setredyintercept(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRedYIntercept(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setredyintercept(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRedYIntercept(float redYIntercept);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setredslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRedSlope(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setredslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRedSlope(float redSlope);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setreddisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRedDisable([MarshalAs(UnmanagedType.U4)] bool redDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setgreenyintercept(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreenYIntercept(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setgreenyintercept(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreenYIntercept(float greenYIntercept);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setgreenslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreenSlope(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setgreenslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreenSlope(float greenSlope);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setgreendisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreenDisable([MarshalAs(UnmanagedType.U4)] bool greenDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setblueyintercept(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlueYIntercept(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setblueyintercept(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlueYIntercept(float blueYIntercept);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setblueslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlueSlope(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setblueslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlueSlope(float blueSlope);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setbluedisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlueDisable([MarshalAs(UnmanagedType.U4)] bool blueDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setalphayintercept(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlphaYIntercept(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setalphayintercept(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlphaYIntercept(float alphaYIntercept);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setalphaslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlphaSlope(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setalphaslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlphaSlope(float alphaSlope);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setalphadisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlphaDisable([MarshalAs(UnmanagedType.U4)] bool alphaDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setclampoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetClampOutput([MarshalAs(UnmanagedType.U4)] bool clampOutput);
}
