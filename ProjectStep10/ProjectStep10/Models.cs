using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep10
{
    public class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public int Percentage { get; set; }
    }

    public class DrinkingGames
    {
        public int ID { get; set; }
        public string GameName { get; set; }
        public string GameDetails { get; set; }

    }
    public class BeerUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int UserAge { get; set; }

    }

    public class ButtonClicks
    {
        public int ClickAmountsPerUser { get; set; }
    }

}
