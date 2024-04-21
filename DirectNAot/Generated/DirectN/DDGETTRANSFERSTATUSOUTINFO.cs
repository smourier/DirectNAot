namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgettransferstatusoutinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDGETTRANSFERSTATUSOUTINFO
{
    public static readonly DDGETTRANSFERSTATUSOUTINFO Null = new();
    
    public nuint dwTransferID;
}
