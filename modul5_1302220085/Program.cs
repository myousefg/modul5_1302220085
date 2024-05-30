public class SimpleDataBase<T>
{
    private List<T> _storedData;
    private List<DateTime> _inputDates;

    public SimpleDataBase()    
    {
        _storedData = new List<T>();
        _inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        _storedData.Add(data);
        _inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < _storedData.Count; i++)
        {
            if (_storedData[i] > (dynamic)0 && _storedData[i] < (dynamic)10)
            {
                Console.WriteLine($"Data " + (i+1) + " berisi: 0" + _storedData[i] +
                    ", yang disimpan pada waktu UTC " + _inputDates[i]);
            }
            else
            {
                Console.WriteLine($"Data " + (i+1) + " berisi: " + _storedData[i] + 
                    ", yang disimpan pada waktu UTC " + _inputDates[i]);
            }
        }
    }
}

public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3) 
    {
        dynamic hasil;
        hasil = angka1 as dynamic + angka2 as dynamic + angka3 as dynamic;
        Console.WriteLine($"Penjumlahan 3 double anda yaitu {hasil}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // method untuk menjumlahkan 3 angka double.
        Penjumlahan jum = new Penjumlahan();
        jum.JumlahTigaAngka<double>(1.5, 2.5, 3.5);
        // method untuk menyimpan data ke database.
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(22);
        // method untuk print isi database dan waktu data tersimpan.
        data.PrintAllData();
    }
}