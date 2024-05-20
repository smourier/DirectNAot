#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ae39362b-45a8-4074-9b9e-ccf49aa2d0b6")]
public partial interface ISpXMLRecoResult : ISpRecoResult
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXMLResult(out PWSTR ppszCoMemXMLResult, SPXMLRESULTOPTIONS Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXMLErrorInfo(ref SPSEMANTICERRORINFO pSemanticErrorInfo);
}
