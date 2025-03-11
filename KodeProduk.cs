namespace modul4_103022300095
{
    internal class KodeProduk
    {
        private static Dictionary<string, string> kodeProduk = new Dictionary<string, string>
        {
            {"Laptop", "E100"},
            {"Smartphone", "E101"},
            {"Tablet", "E102"},
            {"Headset", "E103"},
            {"Keyboard", "E104"},
            {"Mouse", "E105"},
            {"Printer", "E106"},
            {"Monitor", "E107"},
            {"Smartwatch", "E108"},
            {"Kamera", "E109" }
        };

        public static string GetNamaProduk(string kode)
        {
            if (kodeProduk.ContainsKey(kode))
            {
                return kodeProduk[kode];
            }
            else
            {
                return "Produk tidak ditemukan";
            }
        }
    }

    public class Program
    {


        public static void Main()
        {
            Console.WriteLine("Masukkan kode produk: ");
            string kode = Console.ReadLine();
            string namaProduk = KodeProduk.GetNamaProduk(kode);
            Console.WriteLine("Nama Produk: " + namaProduk);
        }
    }
}
