using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belcorp.ApiFGH.ADApi.Model
{
    public class LdapService
    {
        public string Url { get; set; }
        public string BindDn { get; set; }
        public string BindCredentials { get; set; }
        public string SearchBase { get; set; }
        public string SearchFilter { get; set; }
        public string SearchFilterList { get; set; }
        public string AdminCn { get; set; }
    }
}
