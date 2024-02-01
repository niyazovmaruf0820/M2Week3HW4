namespace task2;

public class Airplane : Transprot
{
    protected int passengerPlaces;
    public Airplane(string name, int weight, int power, int fuel, bool doesWork,int passengerPlaces) : base(name,weight,power,fuel,doesWork)
    {
        this.passengerPlaces = passengerPlaces;
    }
    public string Info()
    {
        System.Console.WriteLine(GetInfo());
        return $"PassengerPlaces: {passengerPlaces}";
    }
}
