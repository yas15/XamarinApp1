using System;


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
