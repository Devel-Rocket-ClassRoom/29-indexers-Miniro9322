class Week
{
    private string[] days;

    public Week()
    {
        days = new string[7];
    }

    public Week(int day)
    {
        days = new string[day];
    }

    public int Length { get { return days.Length; } }

    public string this[int index]
    {
        get { return days[index]; }
        set { days[index] = value; }
    }
}