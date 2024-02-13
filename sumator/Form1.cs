using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        private void btnCombine_Click(object sender, EventArgs e)
        {
            CombineFiles();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            SplitFile();
        }

        private void CombineFiles()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text Files|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog.FileNames;
                string combinedText = "";

                foreach (string fileName in fileNames)
                {
                    combinedText += File.ReadAllText(fileName);
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveFileName = saveFileDialog.FileName;
                    File.WriteAllText(saveFileName, combinedText);
                    MessageBox.Show("Files combined successfully!");
                }
            }
        }

        private void SplitFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(fileName);

                int linesPerFile = Convert.ToInt32(txtLinesPerFile.Text);

                List<string> currentLines = new List<string>();
                int fileNumber = 1;

                for (int i = 0; i < lines.Length; i++)
                {
                    currentLines.Add(lines[i]);

                    if (currentLines.Count == linesPerFile || i == lines.Length - 1)
                    {
                        string outputFileName = $"output_{fileNumber}.txt";
                        string outputPath = Path.Combine(Path.GetDirectoryName(fileName), outputFileName);

                        File.WriteAllLines(outputPath, currentLines.ToArray());
                        currentLines.Clear();
                        fileNumber++;
                    }
                }

                MessageBox.Show("File split successfully!");
            }
        }
    }
}
