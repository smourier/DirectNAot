namespace DirectN;

[GeneratedComInterface, Guid("c03ca9fe-fe90-4204-8078-82334cd177da")]
public partial interface IDirectSoundFXParamEq
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSFXParamEq pcDsFxParamEq);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSFXParamEq pDsFxParamEq);
}
