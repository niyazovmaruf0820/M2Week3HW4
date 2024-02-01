namespace task2;

public class CargoPlane : Airplane
{
    public int ton;
    public CargoPlane(string name, int weight, int power, int fuel, bool doesWork,int passengerPlaces, int ton) : base(name,weight,power,fuel,doesWork,passengerPlaces)
    {
        this.ton = ton;
    }
    public string MoreInfo()
    {
        System.Console.WriteLine(Info());
        return $"Ton: {ton}";
    }
}
