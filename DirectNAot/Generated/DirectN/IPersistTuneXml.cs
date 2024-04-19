namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ipersisttunexml
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("0754cd31-8d15-47a9-8215-d20064157244")]
public partial interface IPersistTuneXml : IPersist
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ipersisttunexml-initnew
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitNew();
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ipersisttunexml-load
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load(VARIANT varValue);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ipersisttunexml-save
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save(out VARIANT pvarFragment);
}
