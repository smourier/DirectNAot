using System.Runtime.InteropServices.Marshalling;

namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows8.0")]
[GeneratedComClass]
public unsafe partial class TextHost : ITextHost2, IDisposable
{
    private bool _disposedValue;
    private bool _showCaret;
    private POINT _caretPos;
    private RECT _rect;
    private string? _faceName;
    private int _height;
    private ushort _weight;
    private COLORREF _textColor;
    private COLORREF _backColor;
    private TextHostOptions _options;
    private TXTBACKSTYLE _backStyle;
    private SBOUT _sbout;
    private int _selectionBarWidth;
    private PARAFORMAT_ALIGNMENT _aligment;
    private readonly IComObject<ITextServices2> _services;
    private ComBuffer<CHARFORMAT2W>? _charFormat;
    private ComBuffer<PARAFORMAT2>? _paraFormat;

    public TextHost(TextServicesGenerator generator = TextServicesGenerator.Default)
    {
        _textColor = new COLORREF(); // white
        _backColor = new COLORREF { Value = 0x00FFFFFF }; // transparent
        _options = TextHostOptions.Default;
        _backStyle = TXTBACKSTYLE.TXTBACK_TRANSPARENT;

        var services = this.Create<ITextServices2>(generator);
        if (services == null)
            throw new NotSupportedException();

        _services = services;
        Document = _services.As<ITextDocument2>()!;
    }

    public IComObject<ITextServices2> Services => _services;
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
            using var b = new Bstr(value);
            WithWholeRange(rng => rng.SetText2(0, b)).ThrowOnError();
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
            using var b = new Bstr(value);
            WithWholeRange(rng => rng.SetText2((int)tomConstants.tomConvertRTF, b)).ThrowOnError();
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
            using var b = new Bstr(value);
            WithWholeRange(rng => rng.SetText2((int)tomConstants.tomConvertHtml, b)).ThrowOnError();
        }
    }

    public T WithWholeRange<T>(Func<ITextRange2, T> func)
    {
        ArgumentNullException.ThrowIfNull(func);
        using var range = GetWholeRange();
        return func(range.Object);
    }

    private ComObject<ITextRange2> GetWholeRange()
    {
        Document.Object.Range2(0, 0, out var range).ThrowOnError();
        range.MoveEnd((int)tomConstants.tomStory, 1, out _).ThrowOnError();
        return new ComObject<ITextRange2>(range);
    }

    public virtual POINT CaretPos
    {
        get => _caretPos;
        set
        {
            if (_caretPos == value)
                return;

            _caretPos = value;
        }
    }

    public virtual bool ShowCaret
    {
        get => _showCaret;
        set
        {
            if (_showCaret == value)
                return;

            _showCaret = value;
        }
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

    public virtual int Height
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

    public virtual TXTBACKSTYLE BackStyle
    {
        get => _backStyle;
        set
        {
            if (_backStyle == value)
                return;

            _backStyle = value;
            ResetBackStyle();
        }
    }

    public virtual SBOUT ScrollBars
    {
        get => _sbout;
        set
        {
            if (_sbout == value)
                return;

            _sbout = value;
            ResetScrollBars();
        }
    }

    public virtual int SelectionBarWidth
    {
        get => _selectionBarWidth;
        set
        {
            if (_selectionBarWidth == value)
                return;

            _selectionBarWidth = value;
            ResetSelectionBarWidth();
        }
    }

    public static COLORREF ToColor(D3DCOLORVALUE color)
    {
        int i = color.BR;
        i |= color.BG << 8;
        i |= color.BB << 16;
        i |= color.BA << 24;

        return new COLORREF { Value = (uint)i };
    }

    public static D3DCOLORVALUE ToColor(COLORREF color) => new(color.Value);

    public virtual void ResetSelectionBarWidth([CallerMemberName] string? memberName = null) => ChangeBitNotify(TXTBIT.TXTBIT_SELBARCHANGE, memberName);
    public virtual void ResetBackStyle([CallerMemberName] string? memberName = null) => ChangeBitNotify(TXTBIT.TXTBIT_BACKSTYLECHANGE, memberName);
    public virtual void ResetScrollBars([CallerMemberName] string? memberName = null) => ChangeBitNotify(TXTBIT.TXTBIT_SCROLLBARCHANGE, memberName);
    public virtual void ResetCharFormat([CallerMemberName] string? memberName = null)
    {
        Interlocked.Exchange(ref _charFormat, null)?.Dispose();
        ChangeBitNotify(TXTBIT.TXTBIT_CHARFORMATCHANGE, memberName);
    }

    public virtual void ResetParaFormat([CallerMemberName] string? memberName = null)
    {
        Interlocked.Exchange(ref _paraFormat, null)?.Dispose();
        ChangeBitNotify(TXTBIT.TXTBIT_PARAFORMATCHANGE, memberName);
    }

    public virtual void ChangeBitNotify(TXTBIT bit, [CallerMemberName] string? memberName = null)
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

    public SIZE TxGetNaturalSize2(TXTNATURALSIZE mode, int width, int height, SIZE? extent = null) => TxGetNaturalSize2(mode, width, height, extent, out _);
    public virtual SIZE TxGetNaturalSize2(TXTNATURALSIZE mode, int width, int height, SIZE? extent, out int ascent)
    {
        // for some reason, -1, -1 avoids the himetric mumbo jumbo computation...
        extent ??= new SIZE { cx = -1, cy = -1 };
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

    public void Draw(IComObject<ID2D1RenderTarget> target, RECT rc, RECT? updateRect, TXTVIEW view = TXTVIEW.TXTVIEW_ACTIVE) => Draw(target?.Object!, rc, updateRect, view);
    public virtual void Draw(ID2D1RenderTarget target, RECT rc, RECT? updateRect = null, TXTVIEW view = TXTVIEW.TXTVIEW_ACTIVE)
    {
        ArgumentNullException.ThrowIfNull(target);
        Trace("rc: " + rc + " updateRc:" + updateRect + " view:" + view);
        rc = rc.PixelToDip();
        var rcl = new RECTL { left = rc.left, right = rc.right, top = rc.top, bottom = rc.bottom };
        unsafe
        {
            if (updateRect == null)
            {
                _services.Object.TxDrawD2D(target, ref rcl, ref Unsafe.NullRef<RECT>(), (int)view).ThrowOnError();
            }
            else
            {
                var urc = updateRect.Value;
                _services.Object.TxDrawD2D(target, ref rcl, ref urc, (int)view).ThrowOnError();
            }
        }
    }

    public virtual HRESULT OnTxCharFormatChange(in CHARFORMATW pCF)
    {
        Trace("pCF: " + pCF);
        return Constants.S_OK;
    }

    public virtual HRESULT OnTxParaFormatChange(in PARAFORMAT pPF)
    {
        Trace("pPF: " + pPF);
        return Constants.S_OK;
    }

    public virtual HRESULT TxActivate(nint plOldState)
    {
        Trace("plOldState: " + plOldState);
        return Constants.S_OK;
    }

    public virtual bool TxClientToScreen(nint lppt)
    {
        Trace("lppt: " + lppt);
        return false;
    }

    public virtual bool TxScreenToClient(nint lppt)
    {
        Trace("lppt: " + lppt);
        return false;
    }

    public virtual bool TxCreateCaret(HBITMAP hbmp, int xWidth, int yHeight)
    {
        Trace("hbmp: " + hbmp + " xWidth: " + xWidth + " yHeight: " + yHeight);
        return true;
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

    public virtual bool TxEnableScrollBar(SCROLLBAR_CONSTANTS fuSBFlags, int fuArrowflags)
    {
        Trace("fuSBFlags: " + fuSBFlags + " fuArrowflags: " + (ESB)fuArrowflags);
        return true;
    }

    public virtual void TxFreeTextServicesNotification()
    {
        Trace();
    }

    public virtual HRESULT TxGetAcceleratorPos(nint pcp)
    {
        Trace("pcp: " + pcp);
        if (pcp == 0)
            return Constants.E_INVALIDARG;

        *(int*)pcp = -1;
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetBackStyle(nint pstyle)
    {
        Trace("pstyle: " + pstyle);
        if (pstyle == 0)
            return Constants.E_INVALIDARG;

        *(TXTBACKSTYLE*)pstyle = BackStyle;
        return Constants.S_OK;
    }

    public unsafe virtual HRESULT TxGetCharFormat(nint ppCF)
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
                format.Base.szFaceName = name;
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
            //Trace("fmt: " + format);
        }

        *(nint*)ppCF = _charFormat.DangerousGetHandle();
        //Trace("ppCF: " + ppCF);
        return Constants.S_OK;
    }

    public unsafe virtual HRESULT TxGetParaFormat(nint ppPF)
    {
        if (_paraFormat == null)
        {
            var format = new PARAFORMAT2();
            format.Base.cbSize = (uint)sizeof(PARAFORMAT2);
            format.Base.dwMask = PARAFORMAT_MASK.PFM_ALL2;
            format.wBorderWidth = (ushort)Functions.PointsToTwips(20);
            format.Base.wAlignment = Aligment;
            _paraFormat = new ComBuffer<PARAFORMAT2>(format);
            //Trace("fmt: " + format);
        }

        *(nint*)ppPF = _paraFormat.DangerousGetHandle();
        //Trace("ppPF: " + ppPF);
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetClientRect(nint prc)
    {
        //Trace("prc: " + prc);
        if (prc == 0)
            return Constants.E_INVALIDARG;

        *(RECT*)prc = _rect;
        Trace("rc: " + _rect);
        return Constants.S_OK;
    }

    public virtual nint TxGetDC()
    {
        Trace();
        return 0;
    }

    public virtual int TxReleaseDC(HDC hdc)
    {
        Trace("hdc: " + hdc);
        return 1;
    }

    public virtual HRESULT TxGetEastAsianFlags(nint pFlags)
    {
        Trace("pFlags: " + pFlags);
        if (pFlags == 0)
            return Constants.E_INVALIDARG;

        *(ES*)pFlags = ES.ES_NOIME;
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetEditStyle(uint dwItem, nint pdwData)
    {
        var item = (TXES)dwItem;
        Trace("dwItem: " + item + " pdwData: " + pdwData);
        if (pdwData == 0)
            return Constants.E_INVALIDARG;

        *(TXES*)pdwData = TXES.TXES_ISDIALOG;
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetExtent(nint lpExtent)
    {
        Trace("lpExtent: " + lpExtent);
        if (lpExtent == 0)
            return Constants.E_INVALIDARG;

        *(SIZE*)lpExtent = new SIZE();
        //lpExtent.width = 400;
        //lpExtent.height = 400;
        //lpExtent = lpExtent.PixelToHiMetric();
        //return Constants.S_OK;
        return Constants.E_NOTIMPL;
    }

    public virtual HRESULT TxGetHorzExtent(nint plHorzExtent)
    {
        Trace("plHorzExtent: " + plHorzExtent);
        if (plHorzExtent == 0)
            return Constants.E_INVALIDARG;

        *(int*)plHorzExtent = 0;
        return Constants.E_NOTIMPL;
    }

    public virtual HRESULT TxGetMaxLength(nint plength)
    {
        Trace("plength: " + plength);
        if (plength == 0)
            return Constants.E_INVALIDARG;

        *(int*)plength = -1;
        return Constants.S_OK;
    }

    public virtual nint TxGetPalette()
    {
        Trace();
        return 0;
    }

    public virtual HRESULT TxGetPasswordChar(out sbyte pch)
    {
        pch = 0;
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetPropertyBits(uint dwMask, nint pdwBits)
    {
        var mask = (TXTBIT)dwMask;
        Trace("dwMask: " + mask + " pdwBits: " + pdwBits);
        if (pdwBits == 0)
            return Constants.E_INVALIDARG;

        //pdwBits = dwMask;
        //pdwBits &= ~TXTBIT.TXTBIT_VERTICAL;
        //pdwBits &= ~TXTBIT.TXTBIT_ALLOWBEEP;
        //pdwBits &= ~TXTBIT.TXTBIT_USEPASSWORD;
        //pdwBits &= ~TXTBIT.TXTBIT_READONLY;

        var bits = TXTBIT.TXTBIT_RICHTEXT | TXTBIT.TXTBIT_D2DDWRITE;
        if (_options.HasFlag(TextHostOptions.WordWrap))
        {
            bits |= TXTBIT.TXTBIT_WORDWRAP;
        }

        if (_options.HasFlag(TextHostOptions.Vertical))
        {
            bits |= TXTBIT.TXTBIT_VERTICAL;
        }

        if (_options.HasFlag(TextHostOptions.ReadOnly))
        {
            bits |= TXTBIT.TXTBIT_READONLY;
        }

        if (_options.HasFlag(TextHostOptions.Multiline))
        {
            bits |= TXTBIT.TXTBIT_MULTILINE;
        }

        bits &= mask;
        //pdwBits |= TXTBIT.TXTBIT_UNDOCUMENTED2;
        *(TXTBIT*)pdwBits = bits;
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetScrollBars(nint pdwScrollBar)
    {
        Trace("pdwScrollBar: " + pdwScrollBar);
        if (pdwScrollBar == 0)
            return Constants.E_INVALIDARG;

        *(SBOUT*)pdwScrollBar = ScrollBars;
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetSelectionBarWidth(nint lSelBarWidth)
    {
        Trace("lSelBarWidth: " + lSelBarWidth);
        if (lSelBarWidth == 0)
            return Constants.E_INVALIDARG;

        *(int*)lSelBarWidth = SelectionBarWidth.PixelToHiMetric();
        return Constants.S_OK;
    }

    public virtual uint TxGetSysColor(SYS_COLOR_INDEX nIndex)
    {
        var color = Functions.GetSysColor(nIndex);
        Trace("nIndex: " + nIndex + " color:#" + color.ToString("X8"));
        return color;
    }

    public virtual HRESULT TxGetViewInset(nint prc)
    {
        Trace("prc: " + prc);
        if (prc == 0)
            return Constants.E_INVALIDARG;

        RECT rc;
        rc.left = 0;
        rc.top = 0;
        rc.right = 0;
        rc.bottom = 0;
        rc = rc.PixelToHiMetric();
        *(RECT*)prc = rc;
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetWindow(nint phwnd)
    {
        Trace("phwnd: " + phwnd);
        if (phwnd == 0)
            return Constants.E_INVALIDARG;

        *(nint*)phwnd = 0;
        return Constants.S_OK;
    }

    public virtual HRESULT TxGetWindowStyles(nint pdwStyle, nint pdwExStyle)
    {
        Trace("pdwStyle: " + pdwStyle + " pdwExStyle: " + pdwExStyle);
        if (pdwStyle != 0)
        {
            *(WINDOW_STYLE*)pdwStyle = 0;
        }

        if (pdwExStyle != 0)
        {
            *(WINDOW_EX_STYLE*)pdwExStyle = 0;
        }
        return Constants.S_OK;
    }

    public virtual nint TxImmGetContext()
    {
        Trace();
        return 0;
    }

    public virtual void TxImmReleaseContext(HIMC himc)
    {
        Trace();
    }

    public virtual void TxInvalidateRect(nint prc, BOOL fMode)
    {
        Trace("prc: " + prc + " fMode: " + fMode);
    }

    public virtual bool TxIsDoubleClickPending()
    {
        Trace();
        return false;
    }

    public virtual HRESULT TxNotify(uint iNotify, nint pv)
    {
        Trace("iNotify: " + (EN)iNotify + " pv: " + pv);
        return Constants.S_OK;
    }

    public virtual void TxScrollWindowEx(int dx, int dy, nint lprcScroll, nint lprcClip, HRGN hrgnUpdate, nint lprcUpdate, SCROLL_WINDOW_FLAGS fuScroll)
    {
        Trace("dx: " + dx + " dy: " + dy + " lprcScroll: " + lprcScroll + " lprcClip: " + lprcClip + " hrgnUpdate: " + hrgnUpdate + " lprcUpdate: " + lprcUpdate + " fuScroll: " + fuScroll);
    }

    public virtual void TxSetCapture(BOOL fCapture)
    {
        Trace("fCapture: " + fCapture);
    }

    public virtual bool TxSetCaretPos(int x, int y)
    {
        Trace("x: " + x + " y: " + y);
        CaretPos = new POINT(x, y);
        return true;
    }

    public virtual void TxSetCursor(HCURSOR hcur, BOOL fText) => TxSetCursor2(hcur, fText);
    public virtual nint TxSetCursor2(HCURSOR hcur, BOOL bText)
    {
        Trace("hcur: " + hcur + " bText: " + bText);
        return 0;
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

    public virtual bool TxSetScrollPos(int fnBar, int nPos, BOOL fRedraw)
    {
        Trace("fnBar: " + fnBar + " nPos: " + nPos + " fRedraw: " + fRedraw);
        return true;
    }

    public virtual bool TxSetScrollRange(int fnBar, int nMinPos, int nMaxPos, BOOL fRedraw)
    {
        Trace("fnBar: " + fnBar + " nMinPos: " + nMinPos + " nMaxPos: " + nMaxPos + " fRedraw: " + fRedraw);
        return true;
    }

    public virtual void TxKillTimer(uint idTimer)
    {
        Trace("idTimer: " + idTimer);
    }

    public virtual bool TxSetTimer(uint idTimer, uint uTimeout)
    {
        Trace("idTimer: " + idTimer + " uTimeout: " + uTimeout);
        return true;
    }

    public virtual bool TxShowCaret(BOOL fShow)
    {
        Trace("fShow: " + fShow);
        _showCaret = fShow;
        return true;
    }

    public virtual HRESULT TxShowDropCaret(BOOL fShow, HDC hdc, nint prc)
    {
        Trace("fShow: " + fShow + " hdc: " + hdc + " prc: " + prc);
        return Constants.S_OK;
    }

    public virtual bool TxShowScrollBar(int fnBar, BOOL fShow)
    {
        var bar = (SCROLLBAR_CONSTANTS)fnBar;
        Trace("fnBar: " + bar + " fShow: " + fShow);
        return true;
    }

    public virtual void TxViewChange(BOOL fUpdate)
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

            TextServicesFunctions.Shutdown(_services.Object, true);
#pragma warning disable CA1816 // Dispose methods should call SuppressFinalize
            // we need that in AOT case to avoid crashes in .NET...
            GC.SuppressFinalize(_services.Object);
#pragma warning restore CA1816 // Dispose methods should call SuppressFinalize
            _charFormat?.Dispose();
            _paraFormat?.Dispose();
            _disposedValue = true;
        }
    }

    [Conditional("DEBUG")]
    private static void Trace(string? message = null, [CallerMemberName] string? methodName = null)
    {
        if (!string.IsNullOrEmpty(methodName))
        {
            methodName += "|";
        }

        var name = Thread.CurrentThread.Name.Nullify() ?? Environment.CurrentManagedThreadId.ToString();
        EventProvider.Default.WriteMessageEvent(name + "|" + methodName + message);
    }

    ~TextHost() { Dispose(false); }
    public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
}
