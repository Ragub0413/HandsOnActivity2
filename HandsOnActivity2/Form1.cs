using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HandsOnActivity2
{
    public partial class FrmOpenTextFile : Form
    { 
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text File";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt file (*.txt)| *.txt| All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
           String path = openFileDialog1.FileName;

            using (StreamReader streamReader = File.OpenText(path))
            {
                String _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }

            }

        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
