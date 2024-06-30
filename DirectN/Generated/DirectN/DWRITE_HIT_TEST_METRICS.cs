#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_hit_test_metrics
public partial struct DWRITE_HIT_TEST_METRICS
{
    public uint textPosition;
    public uint length;
    public float left;
    public float top;
    public float width;
    public float height;
    public uint bidiLevel;
    public BOOL isText;
    public BOOL isTrimmed;
}
