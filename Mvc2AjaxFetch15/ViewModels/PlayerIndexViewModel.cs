using System;
using System.Collections.Generic;

namespace Mvc2AjaxFetch15.ViewModels
{
    public class PlayerIndexViewModel
    {
        public string Country { get; set; }
        public DateTime ListGenerated { get; set; }

        public List<Item> Items { get; set; }

        public class Item
        {
            public string Namn { get; set; }
            public string Position { get; set; }
            public int JerseyNumber { get; set; }
        }
    }

    public class PlayerGetPlayersFromViewModel
    {
        public List<Item> Items { get; set; }

        public class Item
        {
            public string Namn { get; set; }
            public string Position { get; set; }
            public int JerseyNumber { get; set; }
        }
    }
}