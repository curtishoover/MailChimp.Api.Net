﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Automations
{
    public class MCAutomationQueue
    {
        public string id { get; set; }
        public string workflow_id { get; set; }
        public string email_id { get; set; }
        public string list_id { get; set; }
        public string email_address { get; set; }
        public List<Link> _links { get; set; }
    }
}
