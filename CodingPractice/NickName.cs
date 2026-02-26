using System.Collections;

class NickName
{
    private Hashtable _names = new Hashtable();

    public string this[string name]
    {
        get { return _names[name].ToString(); }
        set { _names[name] = value; }
    }
}