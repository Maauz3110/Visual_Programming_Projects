namespace _233599_Activity_01.Components.Models
{
   public class CityRepository
{
    public static List<string> cities = new List<string>()
        {
            "America",
            "Pakistan",
            "Australia",
            "SaudiArabia",
            "Iran"
        };
    public static List<string> GetCities() => cities;
}
}
