using System.Runtime.InteropServices;

namespace Lab.Desempenho.StructLayout
{
    [StructLayout(LayoutKind.Auto)]
    public struct Struct2
    {
        public byte Byte;
        public long Long;
        public int Int;
    }
}