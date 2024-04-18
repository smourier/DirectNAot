namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiontabletransfereffect
[GeneratedComInterface, Guid("9b7e82e2-69c5-4eb4-a5f5-a7033f5132cd")]
public partial interface IDCompositionTableTransferEffect : IDCompositionFilterEffect
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setredtable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRedTable(in float tableValues, uint count);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setgreentable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreenTable(in float tableValues, uint count);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setbluetable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlueTable(in float tableValues, uint count);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setalphatable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlphaTable(in float tableValues, uint count);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setreddisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRedDisable([MarshalAs(UnmanagedType.U4)] bool redDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setgreendisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreenDisable([MarshalAs(UnmanagedType.U4)] bool greenDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setbluedisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlueDisable([MarshalAs(UnmanagedType.U4)] bool blueDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setalphadisable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlphaDisable([MarshalAs(UnmanagedType.U4)] bool alphaDisable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setclampoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetClampOutput([MarshalAs(UnmanagedType.U4)] bool clampOutput);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setredtablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRedTableValue(uint index, IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setredtablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRedTableValue(uint index, float value);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setgreentablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreenTableValue(uint index, IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setgreentablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGreenTableValue(uint index, float value);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setbluetablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlueTableValue(uint index, IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setbluetablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBlueTableValue(uint index, float value);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setalphatablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlphaTableValue(uint index, IDCompositionAnimation animation);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiontabletransfereffect-setalphatablevalue(uint_idcompositionanimation)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAlphaTableValue(uint index, float value);
}
