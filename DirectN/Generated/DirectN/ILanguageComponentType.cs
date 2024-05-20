#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ilanguagecomponenttype
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("b874c8ba-0fa2-11d3-9d8e-00c04f72d980")]
public partial interface ILanguageComponentType : IComponentType
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilanguagecomponenttype-get_langid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LangID(out int LangID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilanguagecomponenttype-put_langid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LangID(int LangID);
}
