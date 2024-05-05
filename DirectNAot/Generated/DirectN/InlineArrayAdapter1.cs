#nullable enable
namespace DirectN;

[InlineArray(1)]
public partial struct InlineArrayAdapter1
{
    public static int Length => 1;
    
    public Adapter Data;
}
