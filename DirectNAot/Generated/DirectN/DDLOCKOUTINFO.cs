namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddlockoutinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDLOCKOUTINFO
{
    public static readonly DDLOCKOUTINFO Null = new();
    
    public nuint dwSurfacePtr;
}
