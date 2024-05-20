namespace DirectN.Extensions.Utilities;

public class ColorProfileElement
{
    public ColorProfileElement(uint tag, byte[] bytes)
    {
        ArgumentNullException.ThrowIfNull(bytes);
        Tag = tag;
        Bytes = bytes;
        Type = bytes.Length >= 4 ? ColorProfile.Get4BytesString(BitConverter.ToInt32(bytes, 0)) : null;
    }

    public uint Tag { get; }
    public string? Type { get; }
    public byte[] Bytes { get; }
    public string? TagString => ColorProfile.Get4BytesStringBE(Tag);

    public override string ToString()
    {
        var hexa = Conversions.ToHexa(BitConverter.GetBytes(Tag)) + " '" + TagString + "'";
        if (Type != null)
        {
            hexa += " (" + Type + ")";
        }
        return hexa;
    }
}
