using System;
using System.Collections.Generic;

namespace ServerSideApp.models
{
    public partial class StatusDetails
    {
        public int StatusId { get; set; }
        public string Name { get; set; }
        public string ShopName { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }

    }
}
