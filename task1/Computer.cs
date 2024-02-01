namespace task1;

public class Computer
{
    protected int ram ;
    protected int storage ;
    protected string keyboard ;
    public Computer(int ram, int storage, string keyboard)
    {
        this.ram = ram;
        this.storage = storage;
        this.keyboard = keyboard;
    }
    public void AddRam(int extraram)
    {
        ram += extraram;
    }
    public void AddStorage(int extrastorage)
    {
        storage += extrastorage;
    }
    public string GetInfo()
    {
        return $"Ram: {ram}\nStorage: {storage}\nKeyboard language: {keyboard}";
    }
}
