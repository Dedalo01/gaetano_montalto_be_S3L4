using System.Collections.Generic;

namespace eserS3L4
{
    public class Automobile
    {
        private readonly string _nome;
        private readonly double _prezzoBase;
        private string _imageUrl;
        private List<Optional> _optionals;
        private Garanzia _totaleGaranzia = new Garanzia();

        public double GaranziaTotale
        {
            get
            {
                return _totaleGaranzia.Totale;
            }
        }
        public Automobile(string nome, double prezzoBase, string imageUrl)
        {
            _nome = nome;
            _prezzoBase = prezzoBase;
            _imageUrl = imageUrl;
        }

        public void AddOptional(string nome, double prezzo)
        {
            Optional op = new Optional(nome, prezzo);
            _optionals.Add(op);
        }

        public void AddOptional(Optional op)
        {
            _optionals.Add(op);
        }

        public double TotalOptionalsCost()
        {
            double prezzoTotale = 0;
            foreach (var optional in _optionals)
            {
                prezzoTotale += optional.Prezzo;
            }

            return prezzoTotale;
        }

        public void SetYearsWarranty(int years)
        {
            _totaleGaranzia = new Garanzia(years);
        }
    }

    public class Optional
    {
        private string _nome;
        private double _prezzo;

        public string Nome { get { return _nome; } }
        public double Prezzo
        {
            get
            {
                return _prezzo;
            }
        }

        public Optional(string nome, double prezzo)
        {
            _nome = nome;
            _prezzo = prezzo;
        }
    }

    internal class Garanzia
    {
        private int _totalYears;
        private double _prezzoBase = 120.00;

        internal double Totale
        {
            get
            {
                return _totalYears * _prezzoBase;
            }
        }

        internal Garanzia() { _totalYears = 1; }
        internal Garanzia(int totalYears)
        {
            _totalYears = totalYears;
        }
    }
}