using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupedCVTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageDetail : ContentPage
    {
        public List<DisplayGroupItem> Items { get; set; } = new List<DisplayGroupItem>();

        public MainPageDetail()
        {
            InitializeComponent();

            for (int i = 1; i <= 3; i++)
            {
                List<BasicItem> items = new List<BasicItem>();

                for (int j = 1; j <= 6; j++)
                {
                    items.Add(new BasicItem() { ItemText = j.ToString() });
                }

                DisplayGroupItem dgi = new DisplayGroupItem(i.ToString(), items);                

                Items.Add(dgi);
            }

            BindingContext = this;
        }
    }

    public class DisplayGroupItem : List<BasicItem>
    {
        public string Name { get; set; }

        public DisplayGroupItem(string name, List<BasicItem> basicItems) : base(basicItems)
        {
            Name = name;
        }
    }

    public class BasicItem
    {
        public string ItemText { get; set; }
    }
}