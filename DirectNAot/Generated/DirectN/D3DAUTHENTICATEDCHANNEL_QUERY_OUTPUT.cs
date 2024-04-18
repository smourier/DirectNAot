namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-query-output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT
{
    public D3D_OMAC omac;
    public Guid QueryType;
    public HANDLE hChannel;
    public uint SequenceNumber;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ReturnCode;
}
