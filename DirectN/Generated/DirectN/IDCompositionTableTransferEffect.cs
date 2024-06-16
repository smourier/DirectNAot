#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiontabletransfereffect
[GeneratedComInterface, Guid("9b7e82e2-69c5-4eb4-a5f5-a7033f5132cd")]
public partial interface IDCompositionTableTransferEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setredtable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedTable([In][MarshalUsing(CountElementName = nameof(count))] float[] tableValues, uint count);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setgreentable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGreenTable([In][MarshalUsing(CountElementName = nameof(count))] float[] tableValues, uint count);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setbluetable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlueTable([In][MarshalUsing(CountElementName = nameof(count))] float[] tableValues, uint count);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setalphatable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaTable([In][MarshalUsing(CountElementName = nameof(count))] float[] tableValues, uint count);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setreddisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedDisable(BOOL redDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setgreendisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGreenDisable(BOOL greenDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setbluedisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlueDisable(BOOL blueDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setalphadisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaDisable(BOOL alphaDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setclampoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClampOutput(BOOL clampOutput);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setredtablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedTableValue(uint index, IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setredtablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRedTableValue(uint index, float value);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setgreentablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGreenTableValue(uint index, IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setgreentablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGreenTableValue(uint index, float value);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setbluetablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlueTableValue(uint index, IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setbluetablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBlueTableValue(uint index, float value);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setalphatablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaTableValue(uint index, IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setalphatablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphaTableValue(uint index, float value);
}
