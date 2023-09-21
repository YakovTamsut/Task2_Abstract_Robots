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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            ListOfWorkers();
            ConquerArmy();
            Tasks();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:","Good bye",MessageBoxButton.OK);
            this.Close();
        }


        //משימה 1
        // : כתבו פעולה המחזירה אוסף של 6 עובדים 
        //מנכ"ל אחד, 2 מנהלי תפעול ו-3 עובדי תפעול
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        private List<Worker> ListOfWorkers()
        {
            workers = new List<Worker>();
            workers.Add(new GeneralManager("Zeev", "1", DateTime.Parse("1/1/1940"), "1234", 20000, 69));
            workers.Add(new OperationManager("Ruti", "2", DateTime.Parse("1/1/1999"), "1234", 80, 40,10));
            workers.Add(new OperationManager("Shmulik", "3", DateTime.Parse("1/1/1998"), "1234", 80, 40,10));
            workers.Add(new OperationalWorker("Matan", "4", DateTime.Parse("1/1/1981"), "1234", 80, 40));
            workers.Add(new OperationalWorker("Misha", "5", DateTime.Parse("1/1/1995"), "1234", 80, 40));
            workers.Add(new OperationalWorker("Michael", "6", DateTime.Parse("1/1/1990"), "1234", 80, 40));
            return workers;
        }


        //משימה 2
        //כתבו פעולה המחזירה אוסף של 8 רובוטים
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        private List<RobotSpy> ConquerArmy()
        {
            activeRobots = new List<RobotSpy>();
            activeRobots.Add(new RobotFly("Bone-Breaker:Zx4"));
            activeRobots.Add(new RobotFly("Bone-Breaker:Zx4"));
            activeRobots.Add(new RobotFly("Bone-Breaker:Zx4"));
            activeRobots.Add(new RobotFly("Bone-Breaker:Zx4"));
            activeRobots.Add(new RobotFly("Bone-Breaker:Zx4"));
            activeRobots.Add(new RobotFly("Bone-Breaker:Zx4"));
            activeRobots.Add(new RobotFly("Bone-Breaker:Zx4"));
            activeRobots.Add(new RobotFly("Bone-Breaker:Zx4"));
            return activeRobots;
            
        }

        //משימה 3
        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון       
        private List<Mission> Tasks()
        {
            activeMissions = new List<Mission>();
            activeMissions.Add(new Mission(DateTime.Parse("19/9/2023"),"play amongus with the drones")); 
            activeMissions.Add(new Mission(DateTime.Parse("19/9/2023"),"eliminate 10 humans")); 
            activeMissions.Add(new Mission(DateTime.Parse("19/9/2023"),"text bone cracking abilities")); 
            activeMissions.Add(new Mission(DateTime.Parse("19/9/2023"),"destroy skibidi toilet")); 
            activeMissions.Add(new Mission(DateTime.Parse("19/9/2023"),"create more robots"));
            return activeMissions;
        }

        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            foreach (Worker w in workers) 
            {
                if (tbxID.Text.Equals(w.GetIdNumber()))
                {
                    if (tbxPassword.Password.Equals(w.GetPassword()))
                    {
                        Worker worker = w;
                        WndMain main = new WndMain(worker, activeMissions, activeRobots, workers);
                        main.ShowDialog();
                        return;
                    }
                }
            }

        }
    }
}
