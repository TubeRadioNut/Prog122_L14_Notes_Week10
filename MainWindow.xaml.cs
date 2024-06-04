//Charles Milender
//6-3-2024
//Programming 122
//Lecture 14
using Microsoft.Win32;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Prog122_L14_Notes_Week10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FillComboBox();
            string imgPath = @"C:\Users\rt65s\Documents\Software II\Week 10\Prog122_L14_Notes_Week10\Images\Grade.jpg";
            imgDisplay.Source = ConvertToImage(imgPath);


        }

        public BitmapImage ConvertToImage(string filePath)
        {
            string imgPath = filePath;
            //Uniform Resource Identifier
            Uri converPath = new Uri(imgPath);
            BitmapImage bitmap = new BitmapImage(converPath);
            return bitmap;
        }

        public void FillComboBox()
        {
            Art nighthawks = new Art("Nighthawks", Art.STYLE.Impressionism);

            runDisplay.Text = nighthawks.ToString();
            //EnumComboBox.ItemsSource = Enum.GetValues(typeof(MyEnum)).Cast<MyEnum>().ToList();
            //controlName.ItemsSource = Enum.GetValues(typeof(enumName)).Cast<enumName>().ToList
            cmbStyles.ItemsSource = Enum.GetValues<Art.STYLE>().Cast<Art.STYLE>().ToList();

        }

        private void btnLoadImage_Click(object sender, RoutedEventArgs e)
        {
            //step 1 Open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //Filter
            //What displays in drop down box
            string displayFilter = "Image files (*.png;*jpeg;*.jpg)";
            //What is used to filter results in file explorer
            string filterBy = "*.png;*.jpeg;*.jpg";
            //Full stringf needed
            //MUST HAVE PIPE BETWEEN DISPLAY AND FILTER
            string fullFilter = $"{displayFilter}|{filterBy}";
            //Pass to filter
            openFileDialog.Filter = fullFilter;
            //openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";

            //opens the dialog and returns true if an image is selected
            if (openFileDialog.ShowDialog() == true)
            {
                string returnedFilePath = openFileDialog.FileName;
                imgDisplay.Source = ConvertToImage(returnedFilePath);
            }
        }
    }
}