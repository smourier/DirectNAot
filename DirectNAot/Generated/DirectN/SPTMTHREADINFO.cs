#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPTMTHREADINFO
{
    public int lPoolSize;
    public int lPriority;
    public uint ulConcurrencyLimit;
    public uint ulMaxQuickAllocThreads;
}
