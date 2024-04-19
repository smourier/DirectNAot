namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdmmetadataview
[StructLayout(LayoutKind.Sequential)]
public partial struct WMDMMetadataView
{
    public PWSTR pwszViewName;
    public uint nDepth;
    public nint ppwszTags;
}
