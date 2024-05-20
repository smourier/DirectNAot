#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmcodecinfo2
[GeneratedComInterface, Guid("aa65e273-b686-4056-91ec-dd768d4df710")]
public partial interface IWMCodecInfo2 : IWMCodecInfo
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmcodecinfo2-getcodecname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecName(in Guid guidType, uint dwCodecIndex, [MarshalUsing(CountElementName = nameof(pcchName))] out PWSTR wszName, ref uint pcchName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmcodecinfo2-getcodecformatdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecFormatDesc(in Guid guidType, uint dwCodecIndex, uint dwFormatIndex, out IWMStreamConfig ppIStreamConfig, [MarshalUsing(CountElementName = nameof(pcchDesc))] out PWSTR wszDesc, ref uint pcchDesc);
}
