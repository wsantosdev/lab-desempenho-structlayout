using System.Runtime.InteropServices;

namespace Lab.Desempenho.StructLayout
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Struct3
    {
        public int Int;
        public long Long;
        public int Int2;
    }
}