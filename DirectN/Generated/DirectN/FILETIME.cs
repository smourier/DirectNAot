#nullable enable
namespace DirectN;

// https://learn.microsoft.com/office/client-developer/outlook/mapi/filetime
[StructLayout(LayoutKind.Sequential)]
public partial struct FILETIME
{
    public uint dwLowDateTime;
    public uint dwHighDateTime;
}
