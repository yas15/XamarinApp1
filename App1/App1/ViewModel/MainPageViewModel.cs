using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
    class MainPageViewModel
    {

        public string Prompt { get; set; }
        public string Name { get; set; }

        public MainPageViewModel()
        {
            Prompt = "Name: ";
            Name = "Cristiano Ronaldo";
        }

    }
}
