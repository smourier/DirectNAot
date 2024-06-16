#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositionlineartransfereffect
[GeneratedComInterface, Guid("4305ee5b-c4a0-4c88-9385-67124e017683")]
public partial interface IDCompositionLinearTransferEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setredyintercept(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedYIntercept(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setredyintercept(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedYIntercept(float redYIntercept);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setredslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedSlope(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setredslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedSlope(float redSlope);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setreddisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedDisable(BOOL redDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setgreenyintercept(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGreenYIntercept(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setgreenyintercept(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGreenYIntercept(float greenYIntercept);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setgreenslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGreenSlope(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setgreenslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGreenSlope(float greenSlope);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setgreendisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGreenDisable(BOOL greenDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setblueyintercept(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlueYIntercept(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setblueyintercept(idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlueYIntercept(float blueYIntercept);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setblueslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlueSlope(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setblueslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlueSlope(float blueSlope);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setbluedisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlueDisable(BOOL blueDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setalphayintercept(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaYIntercept(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setalphayintercept(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaYIntercept(float alphaYIntercept);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setalphaslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaSlope(IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setalphaslope(float)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaSlope(float alphaSlope);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setalphadisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaDisable(BOOL alphaDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositionlineartransfereffect-setclampoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClampOutput(BOOL clampOutput);
}
