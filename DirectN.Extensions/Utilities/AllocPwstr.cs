namespace DirectN.Extensions.Utilities;

public class AllocPwstr : Pwstr
{
    public AllocPwstr(int sizeInBytes)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(sizeInBytes);
        SizeInBytes = (uint)sizeInBytes;
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem(sizeInBytes) : 0;
    }

    public AllocPwstr(uint sizeInBytes)
    {
        SizeInBytes = sizeInBytes;
        Value = sizeInBytes > 0 ? Marshal.AllocCoTaskMem((int)sizeInBytes) : 0;
    }

    public uint SizeInBytes { get; }
    public uint SizeInChars => SizeInChars / 2;
}
