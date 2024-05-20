#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3b9c7e7a-6eee-4ded-9092-11657279adbe")]
public partial interface ISpeechTextSelectionInformation : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ActiveOffset(int ActiveOffset);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ActiveOffset(out int ActiveOffset);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ActiveLength(int ActiveLength);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ActiveLength(out int ActiveLength);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SelectionOffset(int SelectionOffset);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SelectionOffset(out int SelectionOffset);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SelectionLength(int SelectionLength);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SelectionLength(out int SelectionLength);
}
