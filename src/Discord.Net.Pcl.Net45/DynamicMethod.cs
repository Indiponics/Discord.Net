using System;

namespace Discord
{
    internal class DynamicMethod
    {
        private object p;
        private Type[] type1;
        private Type type2;
        private string v1;
        private bool v2;

        public DynamicMethod(string v1, object p, Type[] type1, Type type2, bool v2)
        {
            this.v1 = v1;
            this.p = p;
            this.type1 = type1;
            this.type2 = type2;
            this.v2 = v2;
        }

        internal ILGenerator GetILGenerator()
        {
            throw new NotImplementedException();
        }

        internal Action<object, object> CreateDelegate(Type type)
        {
            throw new NotImplementedException();
        }
    }
}