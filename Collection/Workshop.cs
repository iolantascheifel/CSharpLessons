using System.Collections;

namespace Collection;

public class Workshop:IEnumerable<Instrument>
{
    List<Instrument> instruments = new List<Instrument>();
    

    public Instrument this[int i]
    {
        get
        {
            return instruments[i];
        }
    }

    public int Count
    {
        get
        {
            return instruments.Count;
        }
    }

    public void Add(Instrument instrument)
    {
        instruments.Add(instrument);
    }

    public IEnumerator<Instrument> GetEnumerator()
    {
        return new Master(instruments);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}