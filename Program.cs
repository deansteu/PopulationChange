namespace PopulationChange;


class Program
{
    public void LoadCensusTracts(string tractCSVFile){
        Console.WriteLine(tractCSVFile);
    }
    static void Main(string[] args)
    {
        
        string[] cityNames = ["Chicago", "New York", "Washington DC"];
        City[] cities = new City[cityNames.Length];
        for(int i=0; i < cityNames.Length; i++){
            Console.WriteLine(i);
            Console.WriteLine(cityNames[i]);
            cities[i] = new City(name: cityNames[i]);
        }
    }
}
