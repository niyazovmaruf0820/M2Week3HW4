namespace task2;

public class PassengerPlane : Airplane
{
    public int howmanyflaight;
    public PassengerPlane(string name, int weight, int power, int fuel, bool doesWork,int passengerPlaces, int howmanyflaight) : base(name,weight,power,fuel,doesWork,passengerPlaces)
    {
        this.howmanyflaight = howmanyflaight;
    }
    public string MoreInfo()
    {
        System.Console.WriteLine(Info());
        return $"How many flaights: {howmanyflaight}";
    }
}
