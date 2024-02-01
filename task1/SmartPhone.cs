namespace task1;

public class SmartPhone : Computer
{
    private int selfies;
    public SmartPhone(int ram, int storage, string keyboard, int selfies) : base(ram,storage,keyboard)
    {
        this.selfies = selfies;
    }
    public void TakeSelfies()
    {
        selfies ++;
    }
    public string Info()
    {
        System.Console.WriteLine(GetInfo());
        return $"Selfies amount: {selfies}";
    }
}
