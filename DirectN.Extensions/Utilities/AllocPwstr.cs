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

    public static AllocPwstr FromSizeInChars(int countOfChars, bool addOneForTerminatingZero = true)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(countOfChars);
        return new AllocPwstr((uint)((addOneForTerminatingZero ? 1 : 0) + countOfChars) * 2);
    }

    public static AllocPwstr FromSizeInChars(uint countOfChars, bool addOneForTerminatingZero = true)
    {
        ArgumentOutOfRangeException.ThrowIfZero(countOfChars);
        return new AllocPwstr((uint)((addOneForTerminatingZero ? 1 : 0) + countOfChars) * 2);
    }

    public uint SizeInBytes { get; }
    public uint SizeInChars => SizeInBytes / 2;
}
