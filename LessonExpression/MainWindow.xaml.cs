using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace LessonExpression
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Person> people = new List<Person>
            {
                new Person()
                {
                    LastName = "Fucker",
                    FirstName = "Mother",
                    Patronymic="Lover",
                    BirthDate=new DateTime(1980,5,5)
                },
                new Person()
                {
                    LastName = "Fucker1",
                    FirstName = "Mother1",
                    Patronymic="Lover1",
                    BirthDate=new DateTime(1981,5,5)
                }
            };
            tablePerson.ItemsSource = people;
            tablePerson.SelectionChanged += clickColumns;
        }

        private void clickColumns(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
