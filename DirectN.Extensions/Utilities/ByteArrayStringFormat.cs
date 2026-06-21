namespace DirectN.Extensions.Utilities;

public enum ByteArrayStringFormat
{
    // no byte[] <-> string conversion
    None,

    // "0x"-prefixed hex pairs, DirectN's default (parsing accepts any 0x/0X/x/X or none prefix, strict hex pairs)
    Hex,

    Base64
}
