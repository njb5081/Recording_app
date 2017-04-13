using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Recording_app
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool recordingStatus = false;
        public MainPage()
        {
            this.InitializeComponent();

        }
        
        private void recordButton_Click(object sender, RoutedEventArgs e)
        {
            toggleRecording();
            Debug.WriteLine("Button Clicked!");
            Debug.WriteLine((string)recordButton.Content == "Start Recording");
            SolidColorBrush fill = new SolidColorBrush();
            if ((string) recordButton.Content == "Start Recording")
            {
                recordButton.Content = "Stop Recording";
                Debug.WriteLine("In while");
 
                fill.Color = Colors.Red;
                recordIndicator.Fill = fill;
             
            }
            else
            {
                recordButton.Content = "Start Recording";
                fill.Color = Colors.Black;
                recordIndicator.Fill = fill;

            }
        }

        private void waitNmilliSeconds(int milliSec)
        {
            if (milliSec < 1)
            {
                return;
            }
            DateTime desired = DateTime.Now.AddMilliseconds(milliSec);
            while (DateTime.Now < desired)
            {
                Debug.WriteLine("spinning");
            }
        }
       


        private void toggleRecording()
        {
            if (recordingStatus == false)
            {
                Debug.WriteLine("here");
                recordingStatus = true;
            //    return true;
            }
            else
            {
                Debug.WriteLine("erere");
                recordingStatus = false;
              //  return false;
            }
        }
    }
}
