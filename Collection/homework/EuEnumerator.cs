using System.Collections;

namespace Collection.homework;

public class EuEnumerator : IEnumerator<Country>
{
    private List<Country> _countries;
    private int _index = -1;

    public EuEnumerator(List<Country> countries)
    {
        _countries = countries;
    }

    public bool MoveNext()
    {
        _index++;

        while (_index < _countries.Count)
        {
            if (_countries[_index].IsInEu)
            {
                return true; // нашли страну ЕС
            }

            _index++; // пропускаем не-ЕС
        }

        return false; // список кончился
    }

    public Country Current => _countries[_index];

    object IEnumerator.Current => Current;

    public void Reset()
    {
        _index = -1;
    }

    public void Dispose()
    {
        _countries = null;
        Reset();
    }
}