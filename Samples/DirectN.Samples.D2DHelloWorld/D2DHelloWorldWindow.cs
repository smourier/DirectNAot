namespace DirectN.Samples.D2DHelloWorld;

public class D2DHelloWorldWindow() : D2DRenderWindow("Direct2D Hello World")
{
    private readonly Random _rnd = new();
    private Hsv _hsv = Hsv.From(D3DCOLORVALUE.Red);

    protected override void Render(IComObject<ID2D1HwndRenderTarget> renderTarget)
    {
        var cr = ClientRect;
        var w = _rnd.Next(cr.Width);
        var h = _rnd.Next(cr.Height);
        var x = _rnd.Next(0, cr.Width - w);
        var y = _rnd.Next(0, cr.Height - h);

        using var brush = renderTarget.CreateSolidColorBrush(_hsv.ToD3DCOLORVALUE());
        renderTarget.FillRectangle(D2D_RECT_F.Sized(x, y, w, h), brush);

        // this is a simple way to animate in this sample code
        // this will send another WM_PAINT which will call Render again
        // (we could use timer, etc.)
        Invalidate();
        _hsv.Hue += 5;
    }
}
