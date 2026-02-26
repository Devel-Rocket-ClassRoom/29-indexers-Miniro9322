using System.Collections;

class MultiIndexer
{
    private Hashtable _data = new Hashtable();

    public string this[string name]
    {
        get { return _data[name].ToString(); }
        set { _data[name] = value; }
    }

    public string this[int index]
    {
        get { return _data[index].ToString(); }
        set { _data[index] = value; }
    }
}