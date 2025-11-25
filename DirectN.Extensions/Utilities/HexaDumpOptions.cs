namespace DirectN.Extensions.Utilities;

public class HexaDumpOptions
{
    public virtual long StartOffset { get; set; }
    public virtual string? LinePrefix { get; set; }
    public virtual bool AddHeader { get; set; } = true;
    public virtual int BytesPerLine { get; set; } = 16; // minimum is 8
    public virtual Action<TextWriter, byte>? ByteFormatter { get; set; }
}
