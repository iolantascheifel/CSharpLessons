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
        foreach (var country in _countries)
        {
            if (country.IsInEu)
            {
                yield return country;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
