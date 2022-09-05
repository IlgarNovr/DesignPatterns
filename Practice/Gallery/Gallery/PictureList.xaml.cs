using PropertyChanged;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Gallery
{
    [AddINotifyPropertyChangedInterface]
    public partial class PictureList : Page
    {
        public MouseButtonEventHandler DoubleClickHandler { get; set; }
        public ObservableCollection<string> ImgSource { get; private set; }

        public int Columns { get; set; } = 3;
        public PictureList()
        {
            InitializeComponent();
            ImgSource = new ObservableCollection<string>();
            DataContext = this;
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DoubleClickHandler != null)
                DoubleClickHandler.Invoke(sender, e);
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Columns = (int)e.NewSize.Width / 250;
        }

        public void Add(string source)
        {
            if (source.Contains(".png") || source.Contains(".jpg"))
            {
                if (!ImgSource.Contains(source))
                    ImgSource.Add(source);
                else
                    MessageBox.Show($"{source}", "This file already exist", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void AddRange(List<string> sources)
        {
            sources.ForEach(s => Add(s));
        }
    }
}
