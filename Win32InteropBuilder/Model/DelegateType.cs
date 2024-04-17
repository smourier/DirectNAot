using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Win32InteropBuilder.Model
{
    public class DelegateType(FullName fullName) : BuilderType(fullName)
    {
        public virtual CallingConvention? CallingConvention { get; set; }

        protected override void CopyTo(BuilderType copy)
        {
            base.CopyTo(copy);
            if (copy is DelegateType typed)
            {
                typed.CallingConvention = CallingConvention;
            }
        }

        public override void ResolveType(BuilderContext context, TypeDefinition typeDef)
        {
            base.ResolveType(context, typeDef);

            CallingConvention = context.GetCallingConvention(typeDef.GetCustomAttributes());
        }
    }
}
