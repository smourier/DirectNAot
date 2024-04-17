namespace Win32InteropBuilder.Model
{
    public class InterfaceType(FullName fullName) : BuilderType(fullName)
    {
        public virtual bool IsIUnknownDerived { get; set; }

        protected override void CopyTo(BuilderType copy)
        {
            base.CopyTo(copy);
            if (copy is InterfaceType typed)
            {
                typed.IsIUnknownDerived = IsIUnknownDerived;
            }
        }
    }
}
