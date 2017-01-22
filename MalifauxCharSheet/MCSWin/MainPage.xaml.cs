using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.AllJoyn;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Engine.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MCSWin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Session _session;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void buttonAddXp_OnClick(object sender, RoutedEventArgs e)
        {
            _session.buttonAddXp_OnClick();
        }

        private void buttonCreateCharacter_OnClick(object sender, RoutedEventArgs e)
        {
            _session = new Session(TextBoxCharacterName.Text, TextBoxPlayerName.Text);
            DataContext = _session.CurrentCharacter;
        }

        private void buttonAddScrip_OnClick(object sender, RoutedEventArgs e)
        {
            _session.buttonAddScrip_OnClick();
        }
    }
}
