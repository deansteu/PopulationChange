using System.Diagnostics;

namespace PopulationChange;
public class City{
    public string Name{get; set;}
    public int Population{get; set;}
    public CensusTract[] CensusTracts = []; //{get; set;}
    public Neighborhood[] Neighborhoods = []; //{get; set;}

    public City(string name){
        Name = name;
        
    }
    public City(string name, int population){
        Name  = name;
        Population = population;
    }
    public void addNeighborhoods(){
        // read from file, create Neighborhood for each row and add
    }
    public void addCensusTracts(){
        // read from file, create censusTract for each row and add
    }
    
    
}

public class CensusTract{
    public string Id {get; set;}
    public int Population {get; set;}
}

public class Neighborhood{
    public string Name {get; set;}
    public int Population {get; set;}

}
