using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Threading;

namespace PROG6221_Part3_St10071737.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {

        private List<string> funFacts;
        private int currentIndex;
        private DispatcherTimer timer;

        public HomeView()
        {
            InitializeComponent();

            funFacts = new List<string>
        {
            "Fun fact:\n The oldest recipe in the world dates back to around 1700 BCE and is a recipe for beer, written on a Sumerian clay tablet.",
            "Fun fact:\n The world's largest pancake was made in 1994 and measured over 49 feet in diameter and weighed 6,614 pounds.",
            "Fun fact:\n The word 'cook' comes from the Latin word 'coquere,' which means 'to cook' or 'to prepare food.'",
            "Fun fact:\n The first chocolate chip cookie was invented by Ruth Wakefield in the 1930s when she accidentally added chopped chocolate to her cookie dough, expecting it to melt.",
            "Fun fact:\n The tallest cake ever made was over 108 feet tall, created in 2018 in China. It took more than 200 bakers to complete it.",
            "Fun fact:\n The world's most expensive spice is saffron, which is derived from the Crocus flower. It takes about 150,000 flowers to produce just one kilogram of saffron.",
            "Fun fact:\n The world's largest pizza was made in 2012 and measured over 131 feet in diameter.",
            "Fun fact:\n The first recipe book ever written in English was published in 1390 and is called 'The Forme of Cury.' It contains more than 200 recipes.",
            "Fun fact:\n The world record for the most layers in a layer cake is 1,500 layers.",
            "Fun fact:\n The earliest evidence of bread-making dates back to around 14,000 years ago in Jordan.",
            "Fun fact:\n The world's most expensive chocolate is the 'Le Chocolat Box' created by Simon Jewelers. It is priced at $1.5 million and includes diamonds, emeralds, and sapphires.",
            "Fun fact:\n The average American eats around 23 pounds of pizza each year.",
            "Fun fact:\n The world's largest gingerbread house was built in 2013 and covered an area of 2,520 square feet.",
            "Fun fact:\n The chemical compound responsible for the heat in chili peppers is called capsaicin.",
            "Fun fact:\n The pressure inside a champagne bottle is about three times the pressure inside a car tire.",
        };
            // Set the initial fact
            TBFunFacts.Text = funFacts[0];

            //timer to change the fact every 3 seconds
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += Timer_Tick;
            timer.Start();

            TBAbout.Text = "Introducing Digital Bytes – Your Digital Recipe Book!\r\n\r\n" +
                "Digital Bytes is the ultimate companion for home cooks. Store, explore, scale," +
                " and sort your favorite recipes effortlessly. With user-friendly features," +
                " you can organize recipes, adjust quantities, and easily find the perfect dish" +
                " for any occasion. Elevate your cooking adventures with Digital Bytes!";

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Increment the current index or wrap around if the end is reached
            currentIndex = (currentIndex + 1) % funFacts.Count;

            // Update the text with the next fun fact
            TBFunFacts.Text = funFacts[currentIndex];
        }

        private void ResoursesButton_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://github.com/ST10071737/PROG6221_Part3_St10071737/blob/master/Resourses.txt";
            Process.Start(new ProcessStartInfo(websiteUrl));
        }
    }
}

