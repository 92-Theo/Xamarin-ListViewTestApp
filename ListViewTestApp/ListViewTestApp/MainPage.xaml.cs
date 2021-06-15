using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewTestApp
{
    public class ListViewItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int TabIndex { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var list = new List<ListViewItem>();
            for (var i = 1; i < 10; i++)
            {
                list.Add(new ListViewItem() { Name = $"name{i}", Value = $"{i}", TabIndex = i });
            }
            _listView.ItemsSource = list;
        }

       
    }
}
