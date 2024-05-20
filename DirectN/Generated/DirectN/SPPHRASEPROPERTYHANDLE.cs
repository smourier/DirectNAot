#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASEPROPERTYHANDLE
{
    public static readonly SPPHRASEPROPERTYHANDLE Null = new();
    
    public nint Value;
}
