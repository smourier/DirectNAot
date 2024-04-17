namespace Win32InteropBuilder.Model
{
    public interface ILanguage
    {
        string Name { get; }
        string FileExtension { get; }

        void GenerateCode(BuilderContext context, BuilderType type);
    }
}
