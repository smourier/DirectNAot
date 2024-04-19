namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrguid
[StructLayout(LayoutKind.Sequential)]
public partial struct VMRGUID
{
    public nint pGUID;
    public Guid GUID;
}
