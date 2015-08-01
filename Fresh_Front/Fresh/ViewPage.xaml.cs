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
using Windows.Media.Capture;
using Windows.Storage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Fresh
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewPage : Page
    {
        public ViewPage()
        {
            this.InitializeComponent();
        }

        private void Camera_Click(object sender, RoutedEventArgs e)
        {
            // Launch background thread to capture the image and process the file.
            CameraCapture();
        }

        private async void CameraCapture()
        {
            CameraCaptureUI dialog = new CameraCaptureUI();
            Size aspectRatio = new Size(16, 9);
            dialog.PhotoSettings.CroppedAspectRatio = aspectRatio;

            StorageFile file = await dialog.CaptureFileAsync(CameraCaptureUIMode.Photo);
            // TODO: Post photo to service for processing.
        }
    }
}
