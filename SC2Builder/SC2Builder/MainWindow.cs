using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SC2Builder
{
    public partial class MainWindow : Form
    {
        List<Build> loadedBuildOrders;
        Build selectedBuild;
        ImageList imageList;

        public MainWindow()
        {
            loadedBuildOrders = new List<Build>();
            selectedBuild = null;

            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /**
         * On Load
         * 
         *  - Load builds from local file into BuildList ListView component.
         *  - Load build step information and save builds in memory.
         * 
         */
        private void MainWindow_Load(object sender, EventArgs e)
        {
            string[] sFilePaths = Directory.GetFiles(AppPath.GetBuilds());
            Build bRead;

            foreach (string sF in sFilePaths)
            {
                bRead = BuildReader.ReadFromFile(sF);
                if (bRead != null)
                {
                    loadedBuildOrders.Add(bRead);
                }
            }

            PopulateBuildList();
            Application.DoEvents();
        }

        /**
         * Menu Items
         *
         *  - Open Build: loads build file from non-local file.
         *  - Save Build: saves opened build to a local file for future reference.
         * 
         */
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("You opened the file!", "Open File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /**
         * Build Selection
         * 
         *  - Selecting Builds in the ListView will populate Steps ListView.
         *  
         */
        private void BuildList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = BuildList.SelectedItems;
            // our ListView only allows 1 item to be selected at any given time.
            if (selected.Count > 0)
            {
                selectedBuild = null;
                foreach (Build B in loadedBuildOrders)
                {
                    if (B.Equals(selected[0].Text))
                    {
                        this.selectedBuild = B;
                        PopulateStepList();
                        break;
                    }
                }
            }
        }

        private void PopulateBuildList()
        {
            BuildList.Items.Clear();
            foreach (Build B in loadedBuildOrders)
            {
                ListViewItem buildItem = new ListViewItem(B.Name);
                buildItem.ImageIndex = 1;
                BuildList.Items.Add(B.Name);
            }
        }

        private void PopulateStepList()
        {
            StepList.Items.Clear();
            if (selectedBuild != null)
            {
                foreach (Step S in selectedBuild.Steps)
                {
                    ListViewItem stepItem = new ListViewItem(S.ToString());
                    stepItem.ImageIndex = 1;
                    StepList.Items.Add(stepItem);
                }
            }
        }
    }
}
