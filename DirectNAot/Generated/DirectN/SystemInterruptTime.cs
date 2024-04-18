namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentationtypes/ns-presentationtypes-systeminterrupttime
[StructLayout(LayoutKind.Sequential)]
public partial struct SystemInterruptTime
{
    public ulong value;
}
