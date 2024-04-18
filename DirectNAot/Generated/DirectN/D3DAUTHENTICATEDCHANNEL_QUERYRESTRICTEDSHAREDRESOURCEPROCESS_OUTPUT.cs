namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-queryrestrictedsharedresourceprocess-output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_OUTPUT
{
    public D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;
    public uint ProcessIndex;
    public D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE ProcessIdentifer;
    public HANDLE ProcessHandle;
}
