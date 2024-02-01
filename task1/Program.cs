using task1;

Laptop laptop = new Laptop(16, 256, "english",2);
System.Console.WriteLine(laptop.GetInfo());
laptop.WeightChek();
SmartPhone smartPhone = new SmartPhone(4, 32, "russian and english", 0);
smartPhone.TakeSelfies();
smartPhone.TakeSelfies();
smartPhone.TakeSelfies();
System.Console.WriteLine(smartPhone.Info());
