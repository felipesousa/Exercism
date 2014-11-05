using System;
using System.Collections.Generic;
using System.Linq;

public class Allergies
{
    private class Allergen
    {
        private readonly int _code;
        public string Name { get; private set; }

        public Allergen(string name, int code)
        {
            Name = name;
            _code = code;
        }

        public bool Matches(int score)
        {
            return (_code & score) != 0;
        }
    }

    private readonly IList<Allergen> _allergens = new List<Allergen>
    {
        new Allergen("eggs", 1),
        new Allergen("peanuts", 2),
        new Allergen("shellfish", 4),
        new Allergen("strawberries", 8),
        new Allergen("tomatoes", 16),
        new Allergen("chocolate", 32),
        new Allergen("pollen", 64),
        new Allergen("cats", 128)
    };

    private readonly int _score;

    public Allergies(int score)
    {
        _score = score;
    }

    public bool AllergicTo(string item)
    {
        return List().Any(a => a.Equals(item, StringComparison.CurrentCultureIgnoreCase));
    }

    public IList<string> List()
    {
        return _allergens.Where(a => a.Matches(_score)).Select(a => a.Name).ToList();
    }
}