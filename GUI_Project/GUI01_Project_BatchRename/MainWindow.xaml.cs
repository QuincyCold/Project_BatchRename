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
using Fluent;
using System.IO;
using System.ComponentModel;

namespace GUI01_Project_BatchRename
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        static BindingList<string> allFilePathSelected = new BindingList<string>();
 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ribbon_Loaded(object sender, RoutedEventArgs e)
        {
            selectedFileName.ItemsSource = allFilePathSelected;
        }

        private void openfileButton_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Multiselect = true;
            openFileDlg.Filter = "All files (*.*)|*.*";
            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openFileDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            if (result == true)
            {
                for (int i = 0; i < openFileDlg.FileNames.Length; i++)
                {
                    string temp01 = openFileDlg.FileNames[i];
                    bool isDupplicated = false;
                    foreach (string temp02 in allFilePathSelected) //Check dupplication
                    {
                        if (temp01 == temp02)
                            isDupplicated = true;
                    }

                    if (isDupplicated == false)
                    {
                        allFilePathSelected.Add(temp01);
                    }
                }
                //TextBlock1.Text = System.IO.File.ReadAllText(openFileDlg.FileName);
            }
        }
    }
}
