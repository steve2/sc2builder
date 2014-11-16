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
using SC2Builder.Presentation;

namespace SC2Builder
{
    public partial class MainWindow : Form
    {
        /*******************************************************************************
         * Main Application Window
         * 
         *  - Gateway for UI interaction with backend systems.
         * 
         *******************************************************************************/

        private List<Build> loadedBuildOrders;
        private Build selectedBuild;

        public MainWindow()
        {
            loadedBuildOrders = new List<Build>();
            selectedBuild = null;

            SplashWindow splashScreen = new SplashWindow();
            Application.Run(splashScreen);

            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*******************************************************************************
         * Populate ListView Content
         * 
         *  - ListView previews information about build.
         * 
         *******************************************************************************/
        private void PopulateBuildList()
        {
            BuildList.Items.Clear();
            foreach (Build B in loadedBuildOrders)
            {
                ListViewItem buildItem = new ListViewItem(B.Name);
                string[] split = B.MatchUp.Split('-');

                buildItem.SubItems.Add(split[0]);
                buildItem.SubItems.Add("vs. " + split[1]);

                buildItem.ImageIndex = 21;
                BuildList.Items.Add(buildItem);
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
                    stepItem.ImageIndex = 33;
                    StepList.Items.Add(stepItem);
                }
            }
        }

        /*******************************************************************************
         * On Load
         * 
         *  - Load builds from local file into BuildList ListView component.
         *  - Load build step information and save builds in memory.
         * 
         *******************************************************************************/
        private void MainWindow_Load(object sender, EventArgs e)
        {
            string[] sFilePaths;
            Build bRead;

            sFilePaths = Directory.GetFiles(AppPath.GetBuilds());
            foreach (string sF in sFilePaths)
            {
                bRead = BuildReader.ReadFromFile(sF);
                if (bRead != null)
                {
                    loadedBuildOrders.Add(bRead);
                }
            }

            PopulateBuildList();
        }

        /*******************************************************************************
         * Open Build File
         * 
         *  - Opens Build.
         * 
         *******************************************************************************/
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

        /*******************************************************************************
         * Build Selection
         * 
         *  - Selecting Builds in the ListView will populate Steps ListView.
         *  
         *******************************************************************************/
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

        /*******************************************************************************
         * Prevent Column Resizing in ListViews
         *  
         * - Do not want User to potentially lose view of the information.
         *
         *******************************************************************************/
        private void BuildList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
