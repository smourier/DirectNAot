namespace DirectN;

public partial struct COLORREF : IEquatable<OLE_COLOR>
{
	public readonly OLE_COLOR ToOLE_COLOR() => new(Value);

	public readonly bool Equals(OLE_COLOR other) => ToOLE_COLOR().Equals(other);
	public static bool operator ==(OLE_COLOR left, COLORREF right) => right.Equals(left);
	public static bool operator !=(OLE_COLOR left, COLORREF right) => !right.Equals(left);
	public static bool operator ==(COLORREF left, OLE_COLOR right) => left.Equals(right);
	public static bool operator !=(COLORREF left, OLE_COLOR right) => !left.Equals(right);
	public static implicit operator OLE_COLOR(COLORREF vc) => new(vc);
	public static implicit operator COLORREF(OLE_COLOR c) => c.ToCOLORREF();
}
