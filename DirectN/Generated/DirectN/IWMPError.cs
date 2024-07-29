#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmperror
[GeneratedComInterface, Guid("a12dcf7d-14ab-4c1b-a8cd-63909f06025b")]
public partial interface IWMPError : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmperror-clearerrorqueue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT clearErrorQueue();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmperror-get_errorcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_errorCount(ref int plNumErrors);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmperror-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_item(int dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPErrorItem>))] out IWMPErrorItem ppErrorItem);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmperror-webhelp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT webHelp();
}
