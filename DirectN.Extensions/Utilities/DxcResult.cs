namespace DirectN.Extensions.Utilities;

public class DxcResult(IComObject<IDxcResult> result) : DxcResult<IDxcResult>(result) { }
public class DxcResult<T> : InterlockedComObject<T> where T : IDxcResult
{
    private readonly DXC_OUT_KIND[] _outputKinds;

    public DxcResult(IComObject<T> result)
        : base(result)
    {
        ArgumentNullException.ThrowIfNull(result);

        OutputCount = result.Object.GetNumOutputs();
        _outputKinds = new DXC_OUT_KIND[OutputCount];
        for (uint i = 0; i < OutputCount; i++)
        {
            _outputKinds[i] = result.Object.GetOutputByIndex(i);
        }

        PrimaryOutput = result.Object.PrimaryOutput();
        if (result.Object.GetErrorBuffer(out var encoding).IsSuccess)
        {
            using var errorBlob = new DxcBlob(new ComObject<IDxcBlob>(encoding));
            Error = errorBlob.Text;
        }

        result.Object.GetResult(out var res);
        if (res != null)
        {
            Result = new DxcBlob(new ComObject<IDxcBlob>(res));
        }

        result.Object.GetStatus(out var status);
        Status = status;
    }

    public DXC_OUT_KIND PrimaryOutput { get; }
    public DxcBlob? Result { get; }
    public HRESULT Status { get; }
    public string? Error { get; private set; }
    public uint OutputCount { get; }

    public IReadOnlyList<DXC_OUT_KIND> OutputKinds => _outputKinds;
    public virtual DxcResultOutput GetOutput(DXC_OUT_KIND kind)
    {
        var output = new DxcResultOutput(kind);
        ComObject.Object.GetOutput(kind, typeof(IDxcBlob).GUID, out var ppv, out var name);
        if (ppv != 0)
        {
            output.Blob = new DxcBlob(Com.ComObject.FromPointer<IDxcBlob>(ppv)!);
        }

        if (name != null)
        {
            output.Name = ((ID3DBlob)name).GetUnicodeStringFromBlob();
            name.FinalRelease();
        }
        return output;
    }

    public virtual void ThrowOnError()
    {
        if (Status.IsOk)
            return;

        throw new COMException(Error.Nullify() ?? "An error has occured", Status.Value);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Result?.Dispose();
        }
        base.Dispose(disposing);
    }
}
