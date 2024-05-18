namespace DirectNAot.Extensions.Utilities;

public class AllocPwstr : Pwstr
{
    public AllocPwstr(int sizeInBytes)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(sizeInBytes);
        SizeInBytes = sizeInBytes;
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem(sizeInBytes) : 0;
    }

    public AllocPwstr(uint sizeInBytes)
    {
        SizeInBytes = (int)sizeInBytes;
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem((int)sizeInBytes) : 0;
    }

    public int SizeInBytes { get; }
    public int SizeInChars => SizeInChars / 2;
}
