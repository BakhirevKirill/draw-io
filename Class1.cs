using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab34
{
    public class Plant
    {

    }

    public class Flower
    {
        private string _name;
        private string _color;
        private int _price;
        private string _freshness;
        private int _stemLength;

        public Plant Plant { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Freshness
        {
            get { return _freshness; }
            set { _freshness = value; }
        }

        public int StemLength
        {
            get { return _stemLength; }
            set { _stemLength = value; }
        }
    }

    public class Rose : Flower
    {
        private int _budSize;

        public int BudSize
        {
            get { return _budSize; }
            set { _budSize = value; }
        }
    }

    public class Lycoris : Flower
    {
        private int _stamenLength;

        public int StamenLength
        {
            get { return _stamenLength; }
            set { _stamenLength = value; }
        }
    }

    public class Lavandula : Flower
    {
        private int _numberOfFlowers;

        public int NumberOfFlowers
        {
            get { return _numberOfFlowers; }
            set { _numberOfFlowers = value; }
        }
    }

    public class Caninae : Rose
    {
        private string _clade;
        public string Clade
        {
            get { return _clade; }
            set { _clade = value; }
        }
    }

    public class LycorisRadiata : Lycoris
    {
        private string _synonyms;
        public string Synonyms
        {
            get { return _synonyms; }
            set { _synonyms = value; }
        }
    }

    public class LavandulaMultifida : Lavandula
    {
        private string _leaves;
        public string Leaves
        {
            get { return _leaves; }
            set { _leaves = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            FlowerFactory flowerFactory = new FlowerFactory();
            Bouquet bouquet = new Bouquet();
            bouquet.AddFlower(flowerFactory.CreateFlower(1));
            bouquet.AddFlower(flowerFactory.CreateFlower(2));
            bouquet.AddFlower(flowerFactory.CreateFlower(3));
            Console.WriteLine(bouquet.Flowers());
            Console.WriteLine(bouquet.Cost());
        }
    }

    public class FlowerFactory
    {
        public Flower CreateFlower(int n)
        {
            switch(n)
            {
                case 1:
                    return new Caninae() { Price = 10 };
                case 2:
                    return new LycorisRadiata() { Price = 15 };
                case 3:
                    return new LavandulaMultifida() { Price = 20 };
                default:
                    return new Caninae() { Price = 10 };
            }
        }
    }

    public class Bouquet
    {
        Flower[] flowerList = {};
        int totalcost = 0;
        public void AddFlower(Flower flower)
        {
            flowerList.Append(flower);
            totalcost += flower.Price;
        }
        public Flower Flowers()
        {
            for (int i = 0; i < flowerList.Length; i++)
                return flowerList[i];
            return null;
        }
        public int Cost()
        {
            return totalcost;
        }
    }
}
