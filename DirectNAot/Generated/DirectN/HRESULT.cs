namespace DirectN;

// https://learn.microsoft.com/office/client-developer/outlook/mapi/hresult
[StructLayout(LayoutKind.Sequential)]
public partial struct HRESULT
{
    public int Value;
}
