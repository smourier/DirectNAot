#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIORESOURCEMANAGEMENT_RESOURCEGROUP
{
    public BOOL ResourceGroupAcquired;
    public InlineArraySystemChar_256 ResourceGroupName;
}
