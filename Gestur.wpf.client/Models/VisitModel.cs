using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Gestur.wpf.client.Models
{
  class VisitModel
  {
    public long Id { get; set; }
    public DateTime DateTime { get; set; }
    public string PatientTitle { get; set; }
    public string DateTitle { get; set; }
    public string TimeTitle { get; set; }
    public string AddressTitle { get; set; }
    public string Status { get; set; }
    public ImageSource PatientImage { get; set; }
  }
}
