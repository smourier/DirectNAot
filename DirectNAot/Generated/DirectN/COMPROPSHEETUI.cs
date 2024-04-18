namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct COMPROPSHEETUI
{
    public ushort cbSize;
    public ushort Flags;
    public HINSTANCE hInstCaller;
    public nint pCallerName;
    public nuint UserData;
    public nint pHelpFile;
    public nint pfnCallBack;
    public nint pOptItem;
    public nint pDlgPage;
    public ushort cOptItem;
    public ushort cDlgPage;
    public nuint IconID;
    public nint pOptItemName;
    public ushort CallerVersion;
    public ushort OptItemVersion;
    public InlineArrayUIntPtr4 dwReserved;
}
