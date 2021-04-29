using System;
using System.Collections.Generic;

namespace Mvc2AjaxFetch15.ViewModels
{
    public class PlayerIndexViewModel
    {
        public string Country { get; set; }
        public DateTime ListGenerated { get; set; }

        public List<PlayerRowViewModel> Items { get; set; }

    }

    public class PlayerRowViewModel
    {
        public string Namn { get; set; }
        public string Position { get; set; }
        public int JerseyNumber { get; set; }
    }

    public class PlayerGetPlayersFromViewModel
    {
        public List<PlayerRowViewModel> Items { get; set; }

    }
}