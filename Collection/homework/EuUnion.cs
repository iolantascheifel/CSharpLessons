using System.Collections;

namespace Collection.homework;

public class EuUnion : IEnumerable<Country>
{
    private List<Country> _countries = new List<Country>();

    public void Add(Country country)
    {
        _countries.Add(country);
    }

    public Country this[int i]
    {
        get { return _countries[i]; }
    }

    public int Count => _countries.Count;

    public IEnumerator<Country> GetEnumerator()
    {
        return new EuEnumerator(_countries);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
