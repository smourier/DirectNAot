namespace DirectN;

[GeneratedComInterface, Guid("56a868fe-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IAMPlayList
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out uint pdwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemCount(out uint pdwItems);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItem(uint dwItemIndex, out IAMPlayListItem ppItem);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNamedEvent(PWSTR pwszEventName, uint dwItemIndex, out IAMPlayListItem ppItem, out uint pdwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRepeatInfo(out uint pdwRepeatCount, out uint pdwRepeatStart, out uint pdwRepeatEnd);
}
