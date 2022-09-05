using Microsoft.Win32;
using PropertyChanged;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    [AddINotifyPropertyChangedInterface]
    public partial class MainWindow : Window
    {
        PictureList picList;
        public MainWindow()
        {
            InitializeComponent();
            picList = new PictureList();

            List<string> a = new List<string>
            {
                "https://iasbh.tmgrup.com.tr/6f02f2/943/531/23/0/690/375?u=https://isbh.tmgrup.com.tr/sb/album/2019/01/09/mona-lisa-tablosunun-buyuk-sirri-cozuldu-iste-mona-lisanin-gizemi-1547019790330.jpg",
                "https://www.history.com/.image/ar_1:1%2Cc_fill%2Ccs_srgb%2Cfl_progressive%2Cq_auto:good%2Cw_1200/MTU3ODc4NTk4NjgxNjM0NTI3/hith-art-heists-scream-2.jpg",
                "https://images.saatchiart.com/saatchi/84668/art/2220926/1296187-HSC00001-7.jpg",
                "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/2560px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg",
                "https://cdn.vox-cdn.com/thumbor/IKs7gzzqxWseV5B2_kmIRGDACEc=/0x0:2976x1969/1200x0/filters:focal(0x0:2976x1969):no_upscale()/cdn.vox-cdn.com/uploads/chorus_asset/file/3963674/Declaration_independence.jpg",
                "https://www.iesa.edu/sites/default/files/art-history-definition_0.jpg"
            };
            picList.AddRange(a);
            picList.DoubleClickHandler += DoubleClick;
            Page.Navigate(picList);
            DataContext = this;
        }

        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Picture pic = new Picture();
            pic.BackButtonHandler += BackButton;
            pic.ImgSource = (sender as ListBox).SelectedItem as string;
            pic.Images = picList.ImgSource.ToList();
            Page.Navigate(pic);
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            Page.Navigate(picList);
        }

        #region MenuItemsClick
        //Add File
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == true)
            {
                picList.Add(file.FileName);
            }
        }

        //Add Folder
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var folder = new System.Windows.Forms.FolderBrowserDialog();
            if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var directory = new DirectoryInfo(folder.SelectedPath);
                var files = directory.GetFiles();
                foreach (var file in files)
                {
                    picList.Add(file.FullName);
                }
            }
        }

        //Exit
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
