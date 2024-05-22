namespace DirectN.Extensions.Utilities;

public class AllocPstr : Pwstr
{
    public AllocPstr(int sizeInBytes)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(sizeInBytes);
        SizeInBytes = (uint)sizeInBytes;
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem(sizeInBytes) : 0;
    }

    public AllocPstr(uint sizeInBytes)
    {
        SizeInBytes = sizeInBytes;
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem((int)sizeInBytes) : 0;
    }

    public uint SizeInBytes { get; }
    public uint SizeInChars => SizeInChars;
}
