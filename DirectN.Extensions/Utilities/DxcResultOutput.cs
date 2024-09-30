namespace DirectN.Extensions.Utilities;

public class DxcResultOutput(DXC_OUT_KIND kind, DxcBlob blob, string? name)
{
    public DxcBlob Blob { get; } = blob;
    public string? Name { get; } = name;
    public DXC_OUT_KIND Kind => kind;

    public override string ToString()
    {
        var str = Kind.ToString();
        if (Name != null)
        {
            str += " '" + Name + "'";
        }

        var text = Blob?.Text;
        if (text != null)
        {
            str += ": " + text;
        }
        return str;
    }
}
