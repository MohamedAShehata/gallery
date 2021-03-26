using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace gallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void imagesNamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagesNamesList.SelectedIndex >= 0 && tabControl1.SelectedTab == ModePage3 && (statusBar1.Panels[1].Text != "Single picture Mode"))
            {
                OKPage3Button.Enabled = true;
                string imageName = ((IMAGEDATA)(imagesNamesList.SelectedItem)).location;
                if (USEFULTOOLS.imagesDataInDisplayList.ContainsKey(imageName) == false)
                {
                    USEFULTOOLS.imagesDataInDisplayList.Add(imageName, true);
                    IMAGEDATA temp = new IMAGEDATA();
                    temp.name = USEFULTOOLS.getImageName(imageName);
                    temp.location = imageName;
                    DisplayList.Items.Add(temp);
                }
            }
            else if (tabControl1.SelectedTab == menuPage1 && imagesNamesList.SelectedIndex >= 0)
            {
                deletPicturesButton.Enabled = true;
            }
            else if (tabControl1.SelectedTab == ModePage3 && (statusBar1.Panels[1].Text == "Single picture Mode") && imagesNamesList.SelectedIndex >= 0)
            {
                OKPage3Button.Enabled = true;
            }
        }
        private void DisplayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DisplayList.SelectedIndex >= 0)
                deletePage3Button.Enabled = true;
        }
        private void threeModesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (threeModesList.SelectedIndex >= 0)
                OKButtonSelectModePage2.Enabled = true;
        }

        private void menuPage1_Click(object sender, EventArgs e)
        {

        }
        private void addPicturesButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
            openFileDialog1.Multiselect = true;
            DialogResult selectedItems = openFileDialog1.ShowDialog();
            string[] selectedImagesNames = openFileDialog1.FileNames;
            if (selectedItems == DialogResult.OK)
            {
                if (USEFULTOOLS.validateConversion(selectedImagesNames))
                {
                    OKButtonMenu.Enabled = true;
                    USEFULTOOLS.addImagesData(ref imagesNamesList, ref selectedImagesNames);
                }
                else
                {
                    MessageBox.Show("Sorry, but you accidentally chose a file whose extension is not an image.", "Problem detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deletPicturesButton_Click(object sender, EventArgs e)
        {
            USEFULTOOLS.imagesDataInList.Remove(((IMAGEDATA)(imagesNamesList.SelectedItem)).location);
            imagesNamesList.Items.Remove(imagesNamesList.SelectedItem);
            if (imagesNamesList.Items.Count == 0)
            {
                OKButtonMenu.Enabled = false;
            }
            deletPicturesButton.Enabled = false;
        }

        private void deletePage3Button_Click(object sender, EventArgs e)
        {
            USEFULTOOLS.imagesDataInDisplayList.Remove(((IMAGEDATA)(DisplayList.SelectedItem)).location);
            DisplayList.Items.Remove(DisplayList.SelectedItem);
            if (DisplayList.Items.Count == 0)
            {
                OKPage3Button.Enabled = false;
            }
            deletePage3Button.Enabled = false;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OKButtonMenu_Click(object sender, EventArgs e)
        {
            threeModesList.SelectedIndex = -1;
            selectModeToolStripMenuItem.Visible = true;
            exitButton.Parent = selectModePage2;
            GobackButton.Parent = selectModePage2;
            GobackButton.Enabled = true;
            tabControl1.SelectedTab = selectModePage2;
        }
        private void OKButtonSelectModePage2_Click(object sender, EventArgs e)
        {
            selectModeToolStripMenuItem.Visible = false;
            imagesNamesList.Parent = ModePage3;
            imagesNamesList.SelectedIndex = -1;
            label1.Parent = ModePage3;
            GobackButton.Parent = ModePage3;
            exitButton.Parent = ModePage3;
            tabControl1.SelectedTab = ModePage3;
            OKButtonSelectModePage2.Enabled = false;
            if (sender is Button)
            {
                switch (threeModesList.SelectedIndex)
                {
                    case 0:
                        statusBar1.Panels[1].Text = "Single picture Mode";
                        SingleMode();
                        break;
                    case 1:
                        statusBar1.Panels[1].Text = "Multi-Picture Mode";
                        MultiMode();
                        break;
                    default:
                        statusBar1.Panels[1].Text = "Slide Show Mode";
                        SlideShowMode();
                        break;

                }
            }
            else
            {
                var clickedMenuItem = sender as ToolStripMenuItem;
                switch (clickedMenuItem.Text)
                {
                    case "Single picture":
                        statusBar1.Panels[1].Text = "Single picture Mode";
                        SingleMode();
                        break;
                    case "Multi pictures":
                        statusBar1.Panels[1].Text = "Multi-Picture Mode";
                        MultiMode();
                        break;
                    default:
                        statusBar1.Panels[1].Text = "Slide Show Mode";
                        SlideShowMode();
                        break;

                }
            }
        }
        private void OKPage3Button_Click(object sender, EventArgs e)
        {
            OKPage3Button.Visible = false;
            deletePage3Button.Visible = false;
            DisplayList.Visible = false;
            imagesNamesList.Visible = false;
            label1.Visible = false;
            readyToDisplayLabel.Visible = false;
            switch (statusBar1.Panels[1].Text)
            {
                case "Single picture Mode":
                    SingleDisply();
                    break;
                case "Slide Show Mode":
                    SlideShowDisply();
                    break;
                default:
                    MultiDisply();
                    break;

            }
        }
        private void GobackButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true || tabControl1.SelectedTab == multiShowPage4)
            {
                if (tabControl1.SelectedTab == multiShowPage4)
                {
                    tabControl1.SelectedIndex--;
                    GobackButton.Parent = tabControl1.SelectedTab;
                    exitButton.Parent = tabControl1.SelectedTab;
                }
                imagesNamesList.SelectedIndex = -1;
                OKPage3Button.Visible = true;
                if (statusBar1.Panels[1].Text != "Single picture Mode")
                {
                    deletePage3Button.Visible = true;
                    deletePage3Button.Enabled = false;
                    DisplayList.Visible = true;
                    readyToDisplayLabel.Visible = true;
                }
                else if(statusBar1.Panels[1].Text == "Single picture Mode")
                {
                    OKPage3Button.Enabled = false;
                }
                imagesNamesList.Visible = true;
                label1.Visible = true;
                pictureBox1.Visible = false;
                slideShowTimer.Stop();
                DisplayList.SelectedIndex = -1;
            }
            else
            {
                tabControl1.SelectedIndex -= 1;
                if (tabControl1.SelectedTab == selectModePage2)
                {
                    OKButtonSelectModePage2.Enabled = false;
                    selectModeToolStripMenuItem.Visible = true;
                    statusBar1.Panels[1].Text = "";
                    deletePage3Button.Enabled = false;
                    readyToDisplayLabel.Visible = false;
                    threeModesList.SelectedIndex = -1;
                    DisplayList.Visible = true;
                    imagesNamesList.Visible = true;
                    pictureBox1.Visible = false;
                    statusBar1.Panels[2].Text = "";
                }
                imagesNamesList.SelectedIndex = -1;
                imagesNamesList.Parent = menuPage1;
                label1.Parent = menuPage1;
                GobackButton.Parent = tabControl1.SelectedTab;
                exitButton.Parent = tabControl1.SelectedTab;
                if (tabControl1.SelectedIndex == 0)
                {
                    selectModeToolStripMenuItem.Visible = false;
                    GobackButton.Enabled = false;
                }
            }
        }
        private void SingleMode()
        {
            OKPage3Button.Enabled = false;
            readyToDisplayLabel.Visible = false;
            DisplayList.Visible = false;
            deletePage3Button.Visible = false;
        }
        private void MultiMode()
        {
            readyToDisplayLabel.Visible = true;
            OKPage3Button.Enabled = false;
            deletePage3Button.Visible = true;
            DisplayList.Visible = true;
            USEFULTOOLS.imagesDataInDisplayList.Clear();
            DisplayList.Items.Clear();
        }
        private void SlideShowMode()
        {
            readyToDisplayLabel.Visible=true;
            OKPage3Button.Enabled = false;
            deletePage3Button.Visible = true;
            DisplayList.Visible = true;
            USEFULTOOLS.imagesDataInDisplayList.Clear();
            DisplayList.Items.Clear();
        }
        private void SingleDisply()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = ((IMAGEDATA)(imagesNamesList.SelectedItem)).location;
            statusBar1.Panels[2].Text = ((IMAGEDATA)(imagesNamesList.SelectedItem)).name;
            pictureBox1.Visible = true;
        }
        private void MultiDisply()
        {
            flowLayoutPanel1.Controls.Clear();
            GobackButton.Parent = multiShowPage4;
            exitButton.Parent = multiShowPage4;
            tabControl1.SelectedTab = multiShowPage4;
            int Width = flowLayoutPanel1.Size.Width, Height = flowLayoutPanel1.Size.Height, numWidth, numHeight, imgCnt = DisplayList.Items.Count;
            numWidth = (int)Math.Floor(Math.Sqrt(imgCnt));
            numHeight = (int)Math.Ceiling(1.0 * imgCnt / numWidth);
            foreach (var img in DisplayList.Items)
            {
                PictureBox picBox = new PictureBox();
                picBox.Size = new System.Drawing.Size((Width - 10 * numWidth) / numWidth, (Height - 10 * numHeight) / numHeight);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.ImageLocation = ((IMAGEDATA)(img)).location;
                flowLayoutPanel1.Controls.Add(picBox);
            }
        }
        private void SlideShowDisply()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = true;
            go();
            slideShowTimer.Start();
        }
        private void go()
        {
            if (DisplayList.SelectedIndex == DisplayList.Items.Count - 1)
                DisplayList.SelectedIndex = -1;
            DisplayList.SelectedIndex++;
            pictureBox1.ImageLocation = ((IMAGEDATA)(DisplayList.SelectedItem)).location;
            statusBar1.Panels[2].Text = ((IMAGEDATA)(DisplayList.SelectedItem)).name;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void slideShowTimer_Tick(object sender, EventArgs e)
        {
            go();
        }
    }

    /*************************************************************************************************************************/
    /*************************************************************************************************************************/
    /*************************************************************************************************************************/
    /*************************************************************************************************************************/
    /*************************************************************************************************************************/
    public class USEFULTOOLS
    {
        public static SortedDictionary<string, bool> imagesDataInDisplayList = new SortedDictionary<string, bool>();
        public static SortedDictionary<string, bool> imagesDataInList = new SortedDictionary<string, bool>();
        public static void addImagesData(ref ListBox imagesNamesList, ref string[] selectedImagesNames)
        {
            string imageName = "";
            foreach (string i in selectedImagesNames)
            {
                if (imagesDataInList.ContainsKey(i) == false)
                {
                    imageName = getImageName(i);
                    IMAGEDATA temp = new IMAGEDATA();
                    temp.name = imageName;
                    temp.location = i;
                    imagesDataInList.Add(i, true);
                    imagesNamesList.Items.Add(temp);
                }
                else
                {
                    MessageBox.Show("image with this name \" " + getImageName(i) + " \" " + "is already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public static bool validateConversion(string[] names)
        {
            foreach (string i in names)
            {
                try
                {
                    Image.FromFile(i);
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }
        public static string getImageName(string str)
        {
            bool flag = false;
            string res = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                //all files name be like => c:\....\name.extension
                if (str[i] == '\\')
                {
                    res = new string(res.Reverse().ToArray());
                    return res;
                }
                if (flag)
                {
                    res += str[i];
                }
                else if (str[i] == '.')
                {
                    flag = true;
                }
            }
            res = new string(res.Reverse().ToArray());
            return res;
        }
    }
    public class IMAGEDATA : IComparable<IMAGEDATA>
    {

        public string name, location;
        public int CompareTo(IMAGEDATA other)
        {
            return name.CompareTo(other.location);
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
