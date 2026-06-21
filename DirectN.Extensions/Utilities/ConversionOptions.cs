using System;
using System.Globalization;

namespace DirectN.Extensions.Utilities;

public class ConversionOptions
{
    public static ConversionOptions Default { get; } = new();

    public virtual IFormatProvider? Provider { get; init; }

    // resolved provider, never null
    public virtual IFormatProvider FormatProvider => Provider ?? CultureInfo.CurrentCulture;

    public virtual DateTimeStyles DateTimeStyles { get; init; } = DateTimeStyles.None;

    // accept y/yes/on/1 and n/no/off/0, and any non-zero number as true
    public virtual bool LenientBooleans { get; init; } = true;

    // accept 0x hex, the ',' ';' '+' '|' ' ' separators, and multi-value on non-[Flags] enums
    public virtual bool LenientEnums { get; init; } = true;

    // accept long ticks, double OADate and the common ISO 'Z'/compact formats
    public virtual bool LenientDateTime { get; init; } = true;

    // reinterpret byte[] <-> primitive/Guid as raw bytes
    public virtual bool ByteArrayConversions { get; init; } = true;

    // raw byte[] reinterpretation is little-endian by default for determinism across platforms
    public virtual bool ByteArrayBigEndian { get; init; }

    // when true a byte[] source is decoded as UTF-8 text and parsed; when false it is reinterpreted as raw bytes
    public virtual bool ByteArrayAsText { get; init; }

    // byte[] <-> string representation; Hex ("0x..") matches DirectN's default
    public virtual ByteArrayStringFormat ByteArrayStringFormat { get; init; } = ByteArrayStringFormat.Hex;

    // prefix emitted by byte[] -> string in Hex mode; parsing accepts any of 0x/0X/x/X or none regardless
    public virtual HexPrefix ByteArrayHexPrefix { get; init; } = HexPrefix.ZeroX;

    // numeric over/underflow truncates (unchecked) instead of failing the conversion
    public virtual bool TruncateOverflow { get; init; } = true;

    // round fractional inputs to integer targets (banker's rounding, matching DirectN/Convert.ChangeType); set false to truncate toward zero
    public virtual bool RoundFloatingToInteger { get; init; } = true;

    // allow ticks interop both ways: long <-> DateTime/TimeSpan/DateTimeOffset
    public virtual bool DateTimeTicks { get; init; } = true;
}
