namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddtransferininfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDTRANSFERININFO
{
    public nint lpSurfaceData;
    public uint dwStartLine;
    public uint dwEndLine;
    public nuint dwTransferID;
    public uint dwTransferFlags;
    public nint lpDestMDL;
}
