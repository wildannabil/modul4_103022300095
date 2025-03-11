namespace modul4_103022300095
{
    public class Program
    {


        public static void Main()
        {
            Console.WriteLine("Masukkan nama produk: ");
            string kode = Console.ReadLine();
            string namaProduk = KodeProduk.GetNamaProduk(kode);
            Console.WriteLine("Kode Produk: " + namaProduk);

            FanLaptop fan = new FanLaptop();
            while (true)
            {
                Console.Write("Enter Command: ");
                string command = Console.ReadLine();

                if (command == "QUIT") break;

                fan.handlecomand(command);
            }

            Console.WriteLine("Program selesai.");
        }
    }
}
  