using H1_Den_gode_systemudviklerv2.Controller;

namespace H1_Den_gode_systemudviklerv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAnalys dataAnalys = new DataAnalys();
            dataAnalys.MakeDateAnalys();
        }
    }
}