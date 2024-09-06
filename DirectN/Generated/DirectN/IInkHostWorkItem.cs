#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nn-inkpresenterdesktop-iinkhostworkitem
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("ccda0a9a-1b78-4632-bb96-97800662e26c")]
public partial interface IInkHostWorkItem
{
    // https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nf-inkpresenterdesktop-iinkhostworkitem-invoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke();
}
