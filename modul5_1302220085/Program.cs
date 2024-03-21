public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()    
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            if (storedData[i] > (dynamic)0 && storedData[i] < (dynamic)10)
            {
                Console.WriteLine($"Data " + i + " berisi: 0" + storedData[i] + ", yang disimpan pada waktu UTC " + inputDates[i]);
            }
            else
            {
                Console.WriteLine($"Data " + i + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC " + inputDates[i]);
            }
        }
    }
}

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

        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(22);
        data.PrintAllData();
    }
}