namespace DirectNAot.Extensions.Utilities;

public class AllocPstr : Pwstr
{
    public AllocPstr(int sizeInBytes)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(sizeInBytes);
        SizeInBytes = sizeInBytes;
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem(sizeInBytes) : 0;
    }

    public AllocPstr(uint sizeInBytes)
    {
        SizeInBytes = (int)sizeInBytes;
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem((int)sizeInBytes) : 0;
    }

    public int SizeInBytes { get; }
    public int SizeInChars => SizeInChars;
}
