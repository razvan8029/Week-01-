class Car
{
    public Car(string model, int year, string colour)
    {
        this.model = model;
        this.year = year;
        this.colour = colour
    }

    public string model {get => model;
     set => model = value;}
    public int year {get => year; set => 
    year = value}
    public string colour {get => colour; set => 
    colour = value}

    public override string toString()
    {
        return model + " " + year + " " + colour;
    }
}

class Building
{
    private string address;
    private int ConstructionYear;

    public Building (string address; int ConstructionYear)
    {
        this.address = address;
        this.ConstructionYear = ConstructionYear;
    }

    public string address {get => address;
    set => address = value;}
    public string ConstructionYear {get => ConstructionYear;
    set => model = value;}

    public override string toString()
    {
        return address + " " + ConstructionYear;
    }
}

class Street
{
    private int StreetNumber;
    private string StreetName;

    public Street(int StreetNumber; string StreetName)
    {
        this.StreetNumber = StreetNumber;
        this.StreetName = StreetName;
    }

    public int StreetNumber {get => StreetNumber;
    set => StreetNumber = value;}
    public string StreetName { get => StreetName; 
    set => StreetName = value;}

    public override string toString()
    {
        return StreetNumber + " " + StreetName
    }
 }