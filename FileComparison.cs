using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Test
{
    public partial class FileComparison : Form
    {
        Label[] firstDataLabels;
        Label[] secondDataLabels;
        List<Label> differenceLabels;
        public FileComparison()
        {
            InitializeComponent();
            this.differenceLabels = new List<Label>();
            this.firstFileSelectButton.Click += selectFirstFile;
            this.secondFileSelectButton.Click += selectSecondFile;
            this.FindDifference.Click += findDifference;
        }
        public void selectFirstFile(object sender, EventArgs e)
        {
            if(firstDataLabels != null)
            {
                for(int i = 0; i < firstDataLabels.Length;i++)
                {
                    Controls.Remove(firstDataLabels[i]);
                }
            }
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if(result == DialogResult.OK)
            {
                openFile(ofd.FileName, 13, 48, "firstDataLabels");
            }
        }
        public void selectSecondFile(object sender, EventArgs e)
        {
            if (secondDataLabels != null)
            {
                for (int i = 0; i < secondDataLabels.Length; i++)
                {
                    Controls.Remove(secondDataLabels[i]);
                }
            }
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                openFile(ofd.FileName, 571, 48, "secondDataLabels");
            }
        }
        public void findDifference(object sender, EventArgs e)
        {
            if(this.firstDataLabels !=null && this.secondDataLabels!=null)
            {
                FindDataDifference(this.firstDataLabels, this.secondDataLabels, 0, this.FindDifference.Location.Y + 50);
            }
        }
        public void openFile(String path, int x, int y, string label)
        {
            int X = x;
            int Y = y;
            FileInfo fi = new FileInfo(path);
            String[] data = {"Creation Time: "+fi.CreationTime.TimeOfDay.ToString(), "Last Write Time(Day): "+fi.LastWriteTime.Day.ToString(), "Creation Time(Day): "+fi.CreationTime.Day.ToString(),
                "Last Write Time: "+fi.LastWriteTime.TimeOfDay.ToString(),
            "Last Access Time(Day): "+fi.LastAccessTime.Day.ToString(),"Last Access Time: "+fi.LastAccessTime.TimeOfDay.ToString(), "Size(in bytes): "+Convert.ToString(fi.Length),
              "Path To File: "+fi.FullName, "Is Read-Only: "+Convert.ToString(fi.IsReadOnly),
            "File Name: "+fi.Name, "Is Exists: "+Convert.ToString(fi.Exists)};
            if(label.Equals("firstDataLabels"))
            {
                this.firstDataLabels = new Label[data.Length];
            }
            if (label.Equals("secondDataLabels"))
            {
                this.secondDataLabels = new Label[data.Length];
            }
            for (int i = 0; i < data.Length; i++)
            {
                Label dataLabel = new Label();
                dataLabel.BorderStyle=BorderStyle.FixedSingle;
                dataLabel.Text = data[i];
                if(i == 3 || i == 6 || i == 9 || i == 12)
                {
                    Y += dataLabel.Height;
                    X = x;
                }
                dataLabel.AutoSize = true;
                dataLabel.SetBounds(X, Y, dataLabel.Width, dataLabel.Height);
                if(i==1||i==4||i==6||i==9)
                {
                    X += TextRenderer.MeasureText(dataLabel.Text, dataLabel.Font).Width;
                } else
                {
                    X += TextRenderer.MeasureText(dataLabel.Text, dataLabel.Font).Width;
                }
                if (label.Equals("firstDataLabels"))
                {
                    this.firstDataLabels[i] = dataLabel;
                }
                if (label.Equals("secondDataLabels"))
                {
                    this.secondDataLabels[i] = dataLabel;
                }
                Controls.Add(dataLabel);
            }
        }
        public void FindDataDifference(Label[] firstFileData, Label[] secondFileData, int x, int y)
        {
            for(int i = 0; i < differenceLabels.Count;i++)
            {
                Controls.Remove(differenceLabels[i]);
            }
            int X = x;
            int Y = y;
            for(int i = 0; i <firstFileData.Length; i++)
            {
                if (firstFileData[i].Text != secondFileData[i].Text)
                {
                    Label differenceLabel = new Label();
                    differenceLabel.BorderStyle = BorderStyle.FixedSingle;
                    differenceLabel.Text = "Found Difference in: " + firstFileData[i].Text +"/" + secondFileData[i].Text;
                    differenceLabel.AutoSize = true;
                    if(i==3 || i==6 ||i==9||i==12)
                    {
                        Y += differenceLabel.Height;
                        X = x;
                    }
                    differenceLabel.SetBounds(X,Y,differenceLabel.Width,differenceLabel.Height);
                    if (i == 1 || i == 4 || i == 6 || i == 9)
                    {
                        X += TextRenderer.MeasureText(differenceLabel.Text, differenceLabel.Font).Width;
                    }
                    else
                    {
                        X += TextRenderer.MeasureText(differenceLabel.Text, differenceLabel.Font).Width;
                    }
                    differenceLabels.Add(differenceLabel);
                    Controls.Add(differenceLabel);
                }
            }
        }
    }
}
