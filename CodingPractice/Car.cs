class Car
{
    private string[] cars;

    public Car(int length)
    {
        cars = new string[length];
    }

    public int Length
    {
        get { return cars.Length; }
    }

    public string this[int index]
    {
        get { return cars[index]; }
        set { cars[index] = value;}
    }
}