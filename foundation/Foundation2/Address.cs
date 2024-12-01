class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool UsaOrNot()
    {
        return string.Equals(_country, "USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetAddress()
    {
        string isFromUSA = UsaOrNot() ? "Yes" : "No";

        return $"Street Address: {_streetAddress}\nCity: {_city}\nState or Province: {_stateOrProvince}\nIt is from USA?: {isFromUSA}\nCountry: {_country}";
    }
}