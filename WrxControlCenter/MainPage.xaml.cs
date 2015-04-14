using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WrxControlCenter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public List<MainPageOption> applicationOptions = new List<MainPageOption>();

        public MainPage()
        {
            this.InitializeComponent();
            applicationOptions.Add(new MainPageOption("Data Logging", "/Assets/DynoPlot2.jpg"));
            applicationOptions.Add(new MainPageOption("Engine Monitoring", "/Assets/GhostViewEngine.jpg"));
            applicationOptions.Add(new MainPageOption("HUD Settings", "/Assets/Gears.jpg"));
            optionsGridView.DataContext = applicationOptions;
        }
        
        public void OptionClicked(object sender, ItemClickEventArgs e)
        {
            MainPageOption selection = e.ClickedItem as MainPageOption;
            String title = selection.myTitle;
            if (title.Equals("HUD Settings"))
            {
                this.Frame.Navigate(typeof(HUDSettingsPage));
            }
        }
   
    }

    public class MainPageOption
    {

        public MainPageOption(String inTitle, String inImage)
        {
            myTitle = inTitle;
            myImage = inImage;
        }

        public String myTitle { get; set; }
        public String myImage { get; set; }
    }
}
