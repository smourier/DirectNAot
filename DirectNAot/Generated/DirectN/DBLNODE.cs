namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DBLNODE
{
    public nint next;
    public nint prev;
    public nint @object;
    public nint object_int;
}
