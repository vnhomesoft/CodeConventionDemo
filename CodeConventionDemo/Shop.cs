namespace CodeConventionDemo; // recommend to use file-scoped namespace instead of block-scoped (display build warning)

//
public class Shop // interface, class, struct name should be pascal-case
{
    private static string s_defaultName = "Default"; // static field should begin with "s_" and naming using camel-case

    private string _name; // try rename remove underscore prefix and rebuild to see error

    public string DisplayName // property name must be pascal-case
    {
        get { return _name; }
        set { _name = value; }
    }

    public Shop ()
    {
        _name = s_defaultName;
    }

    public string ShortenName() // method name should be pascal-case
    {
        return _name.Substring(Math.Min(_name.Length, 20));
    }

}

public enum ProductCategories
{
    Unspecified,
}

public interface IStock<TKey,TValue> {
    Task Import();
}