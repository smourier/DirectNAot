namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amva/ns-amva-amvainternalmeminfo
[StructLayout(LayoutKind.Sequential)]
public partial struct AMVAInternalMemInfo
{
    public uint dwScratchMemAlloc;
}
