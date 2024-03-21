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
class Program
{
    static void Main(string[] args)
    {
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(22);
        data.PrintAllData();
    }
}