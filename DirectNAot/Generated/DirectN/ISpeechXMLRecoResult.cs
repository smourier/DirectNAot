#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("aaec54af-8f85-4924-944d-b79d39d72e19")]
public partial interface ISpeechXMLRecoResult : ISpeechRecoResult
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXMLResult(SPXMLRESULTOPTIONS Options, out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXMLErrorInfo(out int LineNumber, out BSTR ScriptLine, out BSTR Source, out BSTR Description, out int ResultCode, out VARIANT_BOOL IsError);
}
