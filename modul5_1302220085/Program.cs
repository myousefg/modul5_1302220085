public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3) 
    {
        dynamic hasil;
        hasil = (dynamic)angka1 + (dynamic)angka2 + (dynamic)angka3;
        Console.WriteLine($"Penjumlahan 3 double anda yaitu {hasil}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan jum = new Penjumlahan();
        jum.JumlahTigaAngka<double>(1.5, 2.5, 3.5);
    }
}