using System.Collections;

namespace Collection;

public class Master: IEnumerator<Instrument>
{
    private List<Instrument> instruments;

    private int _count = -1;

    public Master(List<Instrument> instruments)
    {
        this.instruments = instruments;
    }
    
    public bool MoveNext()
    {
        _count++;
        while (_count < instruments.Count)
        {
            if (!instruments[_count].IsBroken)
            {
                return true;
            }
            _count++;
        }
        return false;
    }

    public Instrument Current
    {
        get
        {
            return instruments[_count];
        }
    }
    public void Reset()
    {
        _count = -1;
    }

    object? IEnumerator.Current => Current;

    public void Dispose()
    {
        instruments = null;
        Reset();    
    }
}