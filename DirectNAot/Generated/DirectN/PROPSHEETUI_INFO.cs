namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PROPSHEETUI_INFO
{
    public ushort cbSize;
    public ushort Version;
    public ushort Flags;
    public ushort Reason;
    public HANDLE hComPropSheet;
    public nint pfnComPropSheet;
    public LPARAM lParamInit;
    public nuint UserData;
    public nuint Result;
}
