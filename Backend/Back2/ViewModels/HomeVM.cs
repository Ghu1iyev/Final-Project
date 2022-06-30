using Back2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back2.ViewModels
{
    public class HomeVM
    {
        public List<Portfolio> portfolios   { get; set; }
    }
}
