using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Recording_app
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool recordingStatus;
        public MainPage()
        {
            this.InitializeComponent();

        }
        
        private void recordButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Button Clicked!");
            if ((string) RecordingText.Text == "Start Recording")
            {
                RecordingText.Text = "Stop Recording";
            }
            else
            {
                RecordingText.Text = "Start Recording";
            }
            toggleRecording();
        }


        private bool toggleRecording()
        {
            if (recordingStatus == false)
            {
                recordingStatus = true;
                return true;
            }
            else
            {
                recordingStatus = false;
                return false;
            }
        }
    }
}
