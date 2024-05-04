#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIORESOURCEMANAGEMENT_RESOURCEGROUP
{
    [MarshalAs(UnmanagedType.U4)]
    public bool ResourceGroupAcquired;
    public InlineArraySystemChar256 ResourceGroupName;
}
