namespace DirectN;

public partial struct HANDLE
{
    public static readonly HANDLE Invalid = new();
    public static readonly HANDLE InvalidValue = new(-1);
}

