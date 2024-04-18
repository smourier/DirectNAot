namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgidebug/ns-dxgidebug-dxgi_info_queue_message
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_INFO_QUEUE_MESSAGE
{
    public Guid Producer;
    public DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category;
    public DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity;
    public int ID;
    public nint pDescription;
    public nuint DescriptionByteLength;
}
