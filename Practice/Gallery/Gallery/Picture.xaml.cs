using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Gallery
{
    /// <summary>
    /// Interaction logic for Picture.xaml
    /// </summary>
    /// 
    [AddINotifyPropertyChangedInterface]
    public partial class Picture : Page
    {
        public RoutedEventHandler BackButtonHandler { get; set; }
        public List<string> Images { get; set; }

        DispatcherTimer timer;

        public string ImgSource { get; set; }
        public Picture()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            DataContext = this;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int count = Images.FindIndex(i => i == ImgSource);
            count++;
            if (count == Images.Count)
                count = 0;
            ImgSource = Images[count];
        }

        private void Backward_Click(object sender, RoutedEventArgs e)
        {
            int count = Images.FindIndex(i => i == ImgSource);
            count--;
            if (count < 0)
                count = Images.Count - 1;
            ImgSource = Images[count];
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            Pause.Background = Brushes.LightGray;
            Play.Background = Brushes.White;
            timer.Stop();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Pause.Background = Brushes.White;
            Play.Background = Brushes.LightGray;
            timer.Start();
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            int count = Images.FindIndex(i => i == ImgSource);
            count++;
            if (count == Images.Count)
                count = 0;
            ImgSource = Images[count];
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (BackButtonHandler != null)
                BackButtonHandler.Invoke(sender, e);
        }
    }
}
