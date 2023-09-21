using Robots_inc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Robots_Inc
{
    /// <summary>
    /// Interaction logic for UcWorker.xaml
    /// </summary>
    public partial class UcWorker : UserControl
    {
        public UcWorker(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker;//binding
            lbId.Content += ": " + worker.GetIdNumber();
            lbBirth.Content += ": " + worker.GetBirthDate().ToShortDateString();
            if (worker is OperationalWorker)
            {
                lbRole.Content += ": Boss Tiny";
                workerborder.BorderBrush = Brushes.LightPink; 
                workerborder.Background = Brushes.Pink; 
            }
            if (worker is OperationManager)
            {
                lbRole.Content += ": Small Boss";
                workerborder.BorderBrush = Brushes.MediumPurple;
                workerborder.Background = Brushes.Lavender; 
            }
            if (worker is GeneralManager)
            {
                lbRole.Content += ": Big Boss";
                workerborder.BorderBrush = Brushes.Navy; 
                workerborder.Background = Brushes.CornflowerBlue;
            }
        }
    }
}
