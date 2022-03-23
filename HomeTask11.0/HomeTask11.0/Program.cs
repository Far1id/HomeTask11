using System;

namespace HomeTask11._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static Notebook[] NotebookPrices(Notebook[] notebooks, double minPrice, double maxprice)
        {
            int count = 0;
            foreach (var item in notebooks)
            {
                if (minPrice <= item.Price && item.Price <= maxprice)
                    count++;
            }
            Notebook[] usefullnotebooks = new Notebook[count];
            int j = 0;
            foreach (var item in notebooks)
            {
                if (minPrice <= item.Price && item.Price <= maxprice)
                {
                    usefullnotebooks[j] = new Notebook(item.Price);
                    j++;
                }
            }
            return usefullnotebooks;
        }
    }
}
