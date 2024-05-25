using System.Runtime.InteropServices.Marshalling;
using DirectN.Utilities;

namespace DirectN;

[SupportedOSPlatform("windows8.0")]
[GeneratedComClass]
public partial class TextHost : ITextHost2, IDisposable
{
    private bool _disposedValue;
    private RECT _rect;
    private string? _faceName;
    private int _height;
    private ushort _weight;
    private COLORREF _textColor;
    private COLORREF _backColor;
    private TextHostOptions _options;
    private PARAFORMAT_ALIGNMENT _aligment;
    private readonly IComObject<ITextServices2> _services;
    private ComBuffer<CHARFORMAT2W>? _charFormat;
    private ComBuffer<PARAFORMAT2>? _paraFormat;

    public TextHost(TextServicesGenerator generator = TextServicesGenerator.Default)
    {
        _textColor = new COLORREF { Value = 0xFFFFFF }; // white
        _backColor = new COLORREF { Value = 0x00FFFFFF }; // transparent
        _options = TextHostOptions.Multiline;

        var services = this.Create<ITextServices2>(generator);
        if (services == null)
            throw new NotSupportedException();

        _services = services;
        Document = _services.As<ITextDocument2>()!;
    }

    public IComObject<ITextDocument2> Document { get; }

    public string Generator
    {
        get
        {
            Document.Object.GetGenerator(out var bstr).ThrowOnError();
            var str = bstr.ToString();
            BSTR.Dispose(ref bstr);
            return str ?? string.Empty;
        }
    }

    public virtual string Text
    {
        get
        {
            try
            {
                var bstr = BSTR.Null;
                WithWholeRange(rng => rng.GetText2(0, out bstr).ThrowOnError());
                var str = bstr.ToString();
                BSTR.Dispose(ref bstr);
                return str ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
        set
        {
            using var b = new Bstr(Text);
            WithWholeRange(rng => rng.SetText2(0, b));
        }
    }

    public virtual string RtfText
    {
        get
        {
            try
            {
                var bstr = BSTR.Null;
                WithWholeRange(rng => rng.GetText2((int)(tomConstants.tomConvertRTF | tomConstants.tomGetUtf16), out bstr).ThrowOnError());
                var str = bstr.ToString();
                BSTR.Dispose(ref bstr);
                return str ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
        set
        {
            using var b = new Bstr(RtfText);
            WithWholeRange(rng => rng.SetText2((int)tomConstants.tomConvertRTF, b));
        }
    }

    public virtual string HtmlText
    {
        get
        {
            try
            {
                var bstr = BSTR.Null;
                WithWholeRange(rng => rng.GetText2((int)(tomConstants.tomConvertHtml | tomConstants.tomGetUtf16), out bstr).ThrowOnError());
                var str = bstr.ToString();
                BSTR.Dispose(ref bstr);
                return str ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
        set
        {
            // https://devblogs.microsoft.com/math-in-office/richedit-html-support/
            // note this doesn't seem to work right now...
            using var b = new Bstr(HtmlText);
            WithWholeRange(rng => rng.SetText2((int)tomConstants.tomConvertHtml, b));
        }
    }

    //private void WithWholeRange(Action<ITextRange2> action)
    //{
    //    using var range = GetWholeRange();
    //    action(range.Object);
    //}

    private T WithWholeRange<T>(Func<ITextRange2, T> func)
    {
        using var range = GetWholeRange();
        return func(range.Object);
    }

    private ComObject<ITextRange2> GetWholeRange()
    {
        Document.Object.Range2(0, 0, out var range).ThrowOnError();
        range.MoveEnd((int)tomConstants.tomStory, 1, out _).ThrowOnError();
        return new ComObject<ITextRange2>(range);
    }

    public virtual TextHostOptions Options
    {
        get => _options;
        set
        {
            if (_options == value)
                return;

            var oldValue = _options;
            _options = value;

            var change = (TXTBIT)(oldValue ^ _options);
            ChangeBitNotify(change);
        }
    }

    public virtual COLORREF TextColor
    {
        get => _textColor;
        set
        {
            if (_textColor.Value == value.Value)
                return;

            _textColor = value;
            ResetCharFormat();
        }
    }

    public virtual COLORREF BackColor
    {
        get => _backColor;
        set
        {
            if (_backColor.Value == value.Value)
                return;

            _backColor = value;
            ResetCharFormat();
        }
    }

    public int Height
    {
        get => _height;
        set
        {
            if (_height == value)
                return;

            _height = value;
            ResetCharFormat();
        }
    }

    public virtual ushort Weight
    {
        get => _weight;
        set
        {
            if (_weight == value)
                return;

            _weight = value;
            ResetCharFormat();
        }
    }

    public virtual string? FaceName
    {
        get => _faceName;
        set
        {
            if (_faceName == value)
                return;

            _faceName = value;
            ResetCharFormat();
        }
    }

    public virtual PARAFORMAT_ALIGNMENT Aligment
    {
        get => _aligment;
        set
        {
            if (_aligment == value)
                return;

            _aligment = value;
            ResetParaFormat();
        }
    }

    public static COLORREF ToColor(D3DCOLORVALUE color)
    {
        int i = color.BR;
        i |= color.BG << 8;
        i |= color.BB << 16;
        i |= color.BA << 24;

        // for some reason, white is not 0xFFFFFFFF
        if (i == -1)
            return new COLORREF { Value = 0xFFFFFF };

        return new COLORREF { Value = (uint)i };
    }

    public static D3DCOLORVALUE ToColor(COLORREF color) => new(color.Value);

    private void ResetCharFormat()
    {
        Interlocked.Exchange(ref _charFormat, null)?.Dispose();
        ChangeBitNotify(TXTBIT.TXTBIT_CHARFORMATCHANGE);
    }

    private void ResetParaFormat()
    {
        Interlocked.Exchange(ref _paraFormat, null)?.Dispose();
        ChangeBitNotify(TXTBIT.TXTBIT_PARAFORMATCHANGE);
    }

    protected virtual void ChangeBitNotify(TXTBIT bit)
    {
        if (bit == 0)
            return;

        _services.Object.OnTxPropertyBitsChange((uint)bit, (uint)bit).ThrowOnError();
    }

    public SIZE GetNaturalSize(TXTNATURALSIZE mode, D2D_SIZE_F constraint) => GetNaturalSize(mode, constraint, out _);
    public virtual SIZE GetNaturalSize(TXTNATURALSIZE mode, D2D_SIZE_F constraint, out int ascent)
    {
        Trace("mode: " + mode + " constraint: " + constraint);
        var width = (int)constraint.width;
        if (Options.HasFlag(TextHostOptions.WordWrap))
        {
            if (width == int.MaxValue)
            {
                // not sure we should do this or throw some error
                //Options &= ~TextHostOptions.WordWrap;
            }
        }

        var height = 0; // warning! not sure why this seems to be always good? check vertical mode
        return TxGetNaturalSize2(mode, width, height, null, out ascent);
    }

    protected SIZE TxGetNaturalSize2(TXTNATURALSIZE mode, int width, int height, SIZE? extent = null) => TxGetNaturalSize2(mode, width, height, extent, out _);
    protected virtual SIZE TxGetNaturalSize2(TXTNATURALSIZE mode, int width, int height, SIZE? extent, out int ascent)
    {
        // for some reason, -1, -1 avoids the himetric mumbo jumbo computation...
        extent ??= new SIZE { cx = int.MaxValue, cy = int.MaxValue };
        var ext = extent.Value;
        unsafe
        {
            int asc = 0;
            _services.Object.TxGetNaturalSize2((uint)DVASPECT.DVASPECT_CONTENT, HDC.Null, HDC.Null, ref Unsafe.NullRef<DVTARGETDEVICE>(), (uint)mode, ext, ref width, ref height, ref asc).ThrowOnError();
            ascent = asc;
            return new SIZE(width, height);
        }
    }

    public virtual void Activate(RECT rect)
    {
        _rect = rect;
        _services.Object.OnTxInPlaceActivate(ref rect).ThrowOnError();
        _services.Object.OnTxUIActivate().ThrowOnError();
    }

    public void Draw(IComObject<ID2D1RenderTarget> target, RECT rc) => Draw(target?.Object!, rc);
    public virtual void Draw(ID2D1RenderTarget target, RECT rc)
    {
        ArgumentNullException.ThrowIfNull(target);
        Trace("rc: " + rc);
        rc = rc.PixelToDip();
        var rcl = new RECTL { left = rc.left, right = rc.right, top = rc.top, bottom = rc.bottom };
        unsafe
        {
            _services.Object.TxDrawD2D(target, ref rcl, ref Unsafe.NullRef<RECT>(), (int)TXTVIEW.TXTVIEW_ACTIVE).ThrowOnError();
        }
    }

    public virtual HRESULT OnTxCharFormatChange(ref CHARFORMAT2W pCF)
    {
        Trace("pCF: " + pCF);
        return Constants.S_OK;
    }

    public virtual HRESULT OnTxParaFormatChange(ref PARAFORMAT2 pPF)
    {
        Trace("pPF: " + pPF);
        return Constants.S_OK;
    }

    public virtual HRESULT TxActivate(nint plOldState)
    {
        Trace("plOldState: " + plOldState);
        return Constants.S_OK;
    }

    public virtual bool TxClientToScreen(ref POINT lppt)
    {
        Trace("lppt: " + lppt);
        return false;
    }

    public virtual bool TxScreenToClient(ref POINT lppt)
    {
        Trace("lppt: " + lppt);
        return false;
    }

    public virtual bool TxCreateCaret(HBITMAP hbmp, int xWidth, int yHeight)
    {
        Trace("hbmp: " + hbmp + " xWidth: " + xWidth + " yHeight: " + yHeight);
        return false;
    }

    public virtual HRESULT TxDeactivate(int lNewState)
    {
        Trace("lNewState: " + lNewState);
        return Constants.S_OK;
    }

    public virtual HRESULT TxDestroyCaret()
    {
        Trace();
        return Constants.S_OK;
    }

    public virtual bool TxEnableScrollBar(SB fuSBFlags, ESB fuArrowflags)
    {
        Trace("fuSBFlags: " + fuSBFlags + " fuArrowflags: " + fuArrowflags);
        return true;
    }

    public virtual void TxFreeTextServicesNotification()
    {
        Trace();
    }

    public virtual HRESULT TxGetAcceleratorPos(out int pcp)
    {
        pcp = -1;
        Trace("pcp: " + pcp);
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetBackStyle(out TXTBACKSTYLE pstyle)
    {
        pstyle = TXTBACKSTYLE.TXTBACK_TRANSPARENT;
        Trace("pstyle: " + pstyle);
        return Constants.S_OK;
    }

    public unsafe virtual HRESULT TxGetCharFormat(out nint ppCF)
    {
        if (_charFormat == null)
        {
            var format = new CHARFORMAT2W();
            format.Base.cbSize = (uint)sizeof(CHARFORMAT2W);
            format.Base.dwMask = CFM_MASK.CFM_COLOR | CFM_MASK.CFM_BACKCOLOR;
            format.Base.crTextColor = TextColor;
            format.crBackColor = BackColor;

            var name = FaceName.Nullify();
            if (name != null)
            {
                format.Base.szFaceName = FaceName.Nullify();
                format.Base.dwMask |= CFM_MASK.CFM_FACE;
            }

            format.Base.yHeight = (int)Functions.PointsToTwips(Height);
            if (format.Base.yHeight != 0)
            {
                format.Base.dwMask |= CFM_MASK.CFM_SIZE;
            }

            format.wWeight = Weight;
            if (format.wWeight != 0)
            {
                format.Base.dwMask |= CFM_MASK.CFM_WEIGHT;
            }

            //format.dwEffects = CFE.CFE_AUTOCOLOR;
            //format.dwMask |= CFM.CFM_EFFECTS2;

            _charFormat = new ComBuffer<CHARFORMAT2W>(format);
            Trace("fmt: " + format);
        }

        ppCF = _charFormat.DangerousGetHandle();
        Trace("ppCF: " + ppCF);
        return Constants.S_OK;
    }

    public unsafe virtual HRESULT TxGetParaFormat(out nint ppPF)
    {
        if (_paraFormat == null)
        {
            var format = new PARAFORMAT2();
            format.Base.cbSize = (uint)sizeof(PARAFORMAT2);
            format.Base.dwMask = PARAFORMAT_MASK.PFM_ALL2;
            format.wBorderWidth = (ushort)Functions.PointsToTwips(20);
            format.Base.wAlignment = Aligment;
            _paraFormat = new ComBuffer<PARAFORMAT2>(format);
            Trace("fmt: " + format);
        }

        ppPF = _paraFormat.DangerousGetHandle();
        Trace("ppPF: " + ppPF);
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetClientRect(ref RECT prc)
    {
        prc = _rect;
        Trace("prc: " + prc);
        return Constants.S_OK;
    }

    public virtual HDC TxGetDC()
    {
        Trace();
        return HDC.Null;
    }

    public virtual int TxReleaseDC(HDC hdc)
    {
        Trace("hdc: " + hdc);
        return 1;
    }

    public virtual HRESULT TxGetEastAsianFlags(out ES pFlags)
    {
        pFlags = ES.ES_NOIME;
        Trace("pFlags: " + pFlags);
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetEditStyle(TXES dwItem, out TXES pdwData)
    {
        pdwData = TXES.TXES_ISDIALOG;
        Trace("dwItem: " + dwItem + " pdwData: " + pdwData);
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetExtent(out SIZE lpExtent)
    {
        lpExtent = new SIZE();
        //lpExtent.width = 400;
        //lpExtent.height = 400;
        //lpExtent = lpExtent.PixelToHiMetric();
        Trace("lpExtent: " + lpExtent);
        //return Constants.S_OK;
        return Constants.E_NOTIMPL;
    }

    public virtual HRESULT TxGetHorzExtent(out int plHorzExtent)
    {
        plHorzExtent = 0;
        Trace("plHorzExtent: " + plHorzExtent);
        return Constants.E_NOTIMPL;
    }

    public virtual HRESULT TxGetMaxLength(ref int plength)
    {
        plength = -1;
        Trace("plength: " + plength);
        return Constants.S_OK;
    }

    public virtual HPALETTE TxGetPalette()
    {
        Trace();
        return HPALETTE.Null;
    }

    public virtual HRESULT TxGetPasswordChar(ref char pch)
    {
        Trace("pch: " + pch);
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetPropertyBits(TXTBIT dwMask, ref TXTBIT pdwBits)
    {
        //pdwBits = dwMask;
        //pdwBits &= ~TXTBIT.TXTBIT_VERTICAL;
        //pdwBits &= ~TXTBIT.TXTBIT_ALLOWBEEP;
        //pdwBits &= ~TXTBIT.TXTBIT_USEPASSWORD;
        //pdwBits &= ~TXTBIT.TXTBIT_READONLY;

        pdwBits = TXTBIT.TXTBIT_RICHTEXT | TXTBIT.TXTBIT_D2DDWRITE;
        if (_options.HasFlag(TextHostOptions.WordWrap))
        {
            pdwBits |= TXTBIT.TXTBIT_WORDWRAP;
        }

        if (_options.HasFlag(TextHostOptions.Vertical))
        {
            pdwBits |= TXTBIT.TXTBIT_VERTICAL;
        }

        if (_options.HasFlag(TextHostOptions.ReadOnly))
        {
            pdwBits |= TXTBIT.TXTBIT_READONLY;
        }

        if (_options.HasFlag(TextHostOptions.Multiline))
        {
            pdwBits |= TXTBIT.TXTBIT_MULTILINE;
        }

        pdwBits &= dwMask;
        //pdwBits |= TXTBIT.TXTBIT_UNDOCUMENTED2;
        Trace("dwMask: " + dwMask + " pdwBits: " + pdwBits);
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetScrollBars(out SBOUT pdwScrollBar)
    {
        //pdwScrollBar = SBOUT.WS_VSCROLL | SBOUT.WS_HSCROLL;
        pdwScrollBar = 0;
        Trace("pdwScrollBar: " + pdwScrollBar);
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetSelectionBarWidth(ref int lSelBarWidth)
    {
        lSelBarWidth = 0;
        Trace("lSelBarWidth: " + lSelBarWidth);
        return Constants.S_OK;
    }

    public virtual COLORREF TxGetSysColor(SYS_COLOR_INDEX nIndex)
    {
        //if (nIndex == COLOR.COLOR_WINDOW)
        //    return 0xF03050;

        var color = Functions.GetSysColor(nIndex);
        Trace("nIndex: " + nIndex + " color:#" + color.ToString("X8"));
        return new COLORREF { Value = color };
    }

    public virtual HRESULT TxGetViewInset(ref RECT prc)
    {
        Trace("prc: " + prc);
        prc.left = 0;
        prc.top = 0;
        prc.right = 0;
        prc.bottom = 0;
        prc = prc.PixelToHiMetric();
        Trace("prc: " + prc);
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetWindow(out HWND phwnd)
    {
        phwnd.Value = 0;
        Trace("phwnd: " + phwnd);
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetWindowStyles(out WINDOW_STYLE pdwStyle, out WINDOW_EX_STYLE pdwExStyle)
    {
        pdwStyle = 0;
        pdwExStyle = 0;
        Trace("pdwStyle: " + pdwStyle + " pdwExStyle: " + pdwExStyle);
        return Constants.S_OK;
    }

    public virtual int TxImmGetContext()
    {
        Trace();
        return 0;
    }

    public virtual void TxImmReleaseContext(int himc)
    {
        Trace();
    }

    public virtual void TxInvalidateRect(nint prc, bool fMode)
    {
        Trace("prc: " + prc + " fMode: " + fMode);
    }

    public virtual bool TxIsDoubleClickPending()
    {
        Trace();
        return false;
    }

    public virtual HRESULT TxNotify(int iNotify, nint pv)
    {
        Trace("iNotify: " + iNotify + " pv: " + pv);
        return Constants.S_OK;
    }

    public virtual void TxScrollWindowEx(int dx, int dy, nint lprcScroll, nint lprcClip, nint hrgnUpdate, nint lprcUpdate, TSW fuScroll)
    {
        Trace("dx: " + dx + " dy: " + dy + " lprcScroll: " + lprcScroll + " lprcClip: " + lprcClip + " hrgnUpdate: " + hrgnUpdate + " lprcUpdate: " + lprcUpdate + " fuScroll: " + fuScroll);
    }

    public virtual void TxSetCapture(bool fCapture)
    {
        Trace("fCapture: " + fCapture);
    }

    public virtual bool TxSetCaretPos(int x, int y)
    {
        Trace("x: " + x + " y: " + y);
        return true;
    }

    public virtual void TxSetCursor(HCURSOR hcur, bool fText)
    {
        Trace("hcur: " + hcur + " fText: " + fText);
    }

    public virtual HCURSOR TxSetCursor2(HCURSOR hcur, bool bText)
    {
        Trace("hcur: " + hcur + " bText: " + bText);
        return HCURSOR.Null;
    }

    public virtual void TxSetFocus()
    {
        Trace();
    }

    public virtual HRESULT TxSetForegroundWindow()
    {
        Trace();
        return Constants.S_OK;
    }

    public virtual bool TxSetScrollPos(int fnBar, int nPos, bool fRedraw)
    {
        Trace("fnBar: " + fnBar + " nPos: " + nPos + " fRedraw: " + fRedraw);
        return true;
    }

    public virtual bool TxSetScrollRange(SB fnBar, int nMinPos, int nMaxPos, bool fRedraw)
    {
        Trace("fnBar: " + fnBar + " nMinPos: " + nMinPos + " nMaxPos: " + nMaxPos + " fRedraw: " + fRedraw);
        return true;
    }

    public virtual void TxKillTimer(int idTimer)
    {
        Trace("idTimer: " + idTimer);
    }

    public virtual bool TxSetTimer(int idTimer, int uTimeout)
    {
        Trace("idTimer: " + idTimer + " uTimeout: " + uTimeout);
        return true;
    }

    public virtual bool TxShowCaret(bool fShow)
    {
        Trace("fShow: " + fShow);
        return true;
    }

    public virtual HRESULT TxShowDropCaret(bool fShow, HDC hdc, nint prc)
    {
        Trace("fShow: " + fShow + " hdc: " + hdc + " prc: " + prc);
        return Constants.S_OK;
    }

    public virtual bool TxShowScrollBar(SB fnBar, bool fShow)
    {
        Trace("fnBar: " + fnBar + " fShow: " + fShow);
        return fShow;
    }

    public virtual void TxViewChange(bool fUpdate)
    {
        Trace("fUpdate: " + fUpdate);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                // dispose managed state (managed objects).
            }

            TextServicesFunctions.Shutdown(_services.Object, false);
            _charFormat?.Dispose();
            _paraFormat?.Dispose();
            _disposedValue = true;
        }
    }

    [Conditional("DEBUG")]
    private static void Trace(string? message = null, [CallerMemberName] string? methodName = null) => EventProvider.Default.WriteMessageEvent(methodName + ": " + message);

    ~TextHost() { Dispose(false); }
    public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
}
