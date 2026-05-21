using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.SystemDesign.SplitWise.Modals
{
    public class Group
    {
        public Guid GroupId { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; }
        public List<Expense> Expenses
    }
}
