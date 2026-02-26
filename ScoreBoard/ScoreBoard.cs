using System;

class ScoreBoard
{
    private string[] _names;
    private int[] _scores;
    private int _count;

    public int Count {  get { return _count; } private set { _count = value; } }

    public ScoreBoard(int capacity)
    {
        this._names = new string[capacity];
        this._scores = new int[capacity];
    }

    public void Register(string name, int score)
    {
        if(Count >= _names.Length)
        {
            Console.WriteLine("성적표가 가득 찼습니다.");
        }
        else
        {
            this._names[Count] = name;
            this._scores[Count] = score;
            Count++;
        }
    }

    public string this[int index]
    {
        get
        {
            if(index>Count || index < 0)
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
            int score = 0;
            for(int i = 0; i < Count; i++)
            {
                if (this._names[i] == name)
                {
                    score = _scores[i];
                    break;
                }
                else
                {
                    score = -1;
                }
            }
            return score;
        }

        set
        {
            for (int i = 0; i < Count; i++)
            {
                if (this._names[i] == name)
                {
                    this._scores[i] = value;
                    break;
                }
            }
        }
    }
}