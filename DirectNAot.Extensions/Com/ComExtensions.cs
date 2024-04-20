namespace DirectNAot.Extensions.Com
{
    public static class ComExtensions
    {
        public static void FinalRelease(this object? comObject)
        {
            if (comObject == null)
                return;

            // note: only works on unique instance objects
            ((ComObject)comObject).FinalRelease();
        }
    }
}
