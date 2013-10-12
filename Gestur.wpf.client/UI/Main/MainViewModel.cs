using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Gestur.Core.Wpf.Util;
using Gestur.wpf.client.Models;
using Windows.Media.Capture;

namespace Gestur.wpf.client.UI.Main
{
  class MainViewModel
    :ViewModelBase
  {
    private static readonly Uri MaleImagePath = new Uri(@"F:\Code\GitHub\Gestur\Gestur.wpf.client\Resources\Images\male_96.png");
    private static readonly Uri FemaleImagePath = new Uri(@"F:\Code\GitHub\Gestur\Gestur.wpf.client\Resources\Images\girl_96.png");

    private readonly MainWindow _view;

    public MainViewModel()
    {
      Model = new MainModel
        {
          Visits = new List<VisitModel>
            {
              new VisitModel
                {
                  AddressTitle = "15 Victory Street - NY",
                  PatientImage = new BitmapImage(MaleImagePath),
                  PatientTitle = "Joe Bloggs",
                  DateTitle = "21 May 2013",
                  TimeTitle = "15:30"
                },
              new VisitModel
                {
                  AddressTitle = "32 Whiteriver Av. - NY",
                  PatientImage = new BitmapImage(FemaleImagePath),
                  PatientTitle = "Mary Flies",
                  DateTitle = "21 May 2013",
                  TimeTitle = "17:30"
                }
            }
        };            
      _view = new MainWindow {DataContext = this};
      _view.ShowDialog();
    }

    async private void CameraCapture()
    {
      var cameraUI = new CameraCaptureUI();
      var capturedMedia =  cameraUI.CaptureFileAsync(CameraCaptureUIMode.Video);
      var results = capturedMedia.GetResults();


    }

    public MainModel Model { get; set; }
  }
}
