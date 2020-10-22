using SQLite;

namespace AppSample.Models
{
    public class MyArray
    {
        public string id { get; set; }
        public string type { get; set; }
        public HumidAmbiente humidAmbiente { get; set; }
        public HumidSolo humidSolo { get; set; }
        public Luminosidade luminosidade { get; set; }
        public TempAmbiente tempAmbiente { get; set; }
        public TempSolo tempSolo { get; set; }
        public PH pH { get; set; }

    }

    public class Metadata { }

    public class HumidAmbiente
    {
        public string type { get; set; }
        public double value { get; set; }
        public Metadata metadata { get; set; }
    }

    public class HumidSolo
    {
        public string type { get; set; }
        public double value { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Luminosidade
    {
        public string type { get; set; }
        public double value { get; set; }
        public Metadata metadata { get; set; }
    }

    public class TempAmbiente
    {
        public string type { get; set; }
        public double value { get; set; }
        public Metadata metadata { get; set; }
    }

    public class TempSolo
    {
        public string type { get; set; }
        public double value { get; set; }
        public Metadata metadata { get; set; }
    }

    public class PH
    {
        public string type { get; set; }
        public double value { get; set; }
        public Metadata metadata { get; set; }
    }
}