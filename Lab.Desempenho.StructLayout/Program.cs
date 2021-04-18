using ObjectLayoutInspector;

namespace Lab.Desempenho.StructLayout
{
    static class Program
    {
        static void Main(string[] args)
        {
            TypeLayout.PrintLayout<Struct1>();
            TypeLayout.PrintLayout<Struct2>();
            TypeLayout.PrintLayout<Struct3>();
            TypeLayout.PrintLayout<Struct4>();
        }
    }
}