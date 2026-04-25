using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticSearchDemo.Models
{
    public class CustomerProfile
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;
        public string RecommendedService { get; set; }= string.Empty;
        public string PreferredTime { get; set; } = string.Empty;

    }
}
