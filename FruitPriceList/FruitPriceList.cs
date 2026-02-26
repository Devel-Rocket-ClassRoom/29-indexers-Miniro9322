using System;
using System.Collections;

class FruitPriceList
{
    private string[] _names;
    private int[] _prices;
    private int _count;

    public int Count {  get { return _count; } }
    public FruitPriceList(int capacity)
    {
        _names = new string[capacity];
        _prices = new int[capacity];
        _count = 0;
    }

    public void Add(string name, int price)
    {
        if(Count >= _prices.Length)
        {
            Console.WriteLine("가격표가 가득 찼습니다.");
        }
        else
        {
            _names[Count] = name;
            _prices[Count] = price;
            this._count++;
        }

    }

    public string this[int index]
    {
        get
        {
            if(index > Count || index < 0)
            {
                return String.Empty;
            }
            else
            {
                return _names[index];
            }
        }
    }

    public int this[string name]
    {
        get
        {
            int price = 0;
            for(int i = 0; i < _names.Length; i++)
            {
                if( _names[i] == name)
                {
                    price =  _prices[i];
                    break;
                }
                else
                {
                    price = - 1;
                }
            }

            return price;
        }
    }
}