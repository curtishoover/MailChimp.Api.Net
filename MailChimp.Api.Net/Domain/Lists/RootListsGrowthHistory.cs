﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    public class RootListsGrowthHistory
    {
        public List<History> history { get; set; }
        public string list_id { get; set; }
        public int total_items { get; set; }
        public List<Link2> _links { get; set; }
    }
}
