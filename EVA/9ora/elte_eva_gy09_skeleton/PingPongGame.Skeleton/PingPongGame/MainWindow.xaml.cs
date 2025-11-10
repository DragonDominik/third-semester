using PingPongGame.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PingPongGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public EventHandler<Thickness>? BallLayoutUpdated;
        public EventHandler<Thickness>? PadLayoutUpdated;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void StartBallAnimation(Thickness nextPosition)
        {
            ThicknessAnimation animation = new ThicknessAnimation
            {
                From = Ball.Margin,
                To = nextPosition,
                Duration = new Duration(TimeSpan.FromMilliseconds(5)),
                SpeedRatio = 1 / TravelDistance(Ball.Margin, nextPosition)
                // Speed depends on the distance to travel
            };
            Ball.BeginAnimation(Ellipse.MarginProperty, animation,
            HandoffBehavior.SnapshotAndReplace);
        }

        public void StartPadAnimation(Thickness nextPosition)
        {
            ThicknessAnimation animation = new ThicknessAnimation
            {
                From = Pad.Margin,
                To = nextPosition,
                Duration = new Duration(TimeSpan.FromMilliseconds(100)),
            };
            Pad.BeginAnimation(Rectangle.MarginProperty, animation,
            HandoffBehavior.SnapshotAndReplace);
        }

        private void OnBallLayoutUpdated(object? sender, EventArgs e)
        {
            BallLayoutUpdated?.Invoke(this, Ball.Margin);
        }

        private void OnPadLayoutUpdated(object? sender, EventArgs e)
        {
            PadLayoutUpdated?.Invoke(this, Pad.Margin);
        }

        private double TravelDistance(Thickness currentPosition, Thickness nextPosition)
        {
            double dx = nextPosition.Left - currentPosition.Left;
            double dy = nextPosition.Top - currentPosition.Top;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}