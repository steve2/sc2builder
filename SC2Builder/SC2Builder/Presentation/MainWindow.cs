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
using SC2Builder.Logic;

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

        public const string DUPLICATES_ERROR = "Error: Build already exists with this name.";
        public const string SELECTION_ERROR = "Error: No build is currently selected.";
        public const string INVALID_ERROR = "Error: Build contains invalid information.";

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

                buildItem.SubItems.Add(B.Race);
                buildItem.SubItems.Add("vs. " + B.Versus);

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

        private void ClearBuildEditor()
        {
            RaceBox.SelectedIndex = -1;
            MatchupBox.SelectedIndex = -1;
            NameBox.Text = null;
        }

        private void PopulateBuildEditor()
        {
            if (selectedBuild != null)
            {
                if (selectedBuild.Race.Equals("Terran"))
                    RaceBox.SelectedIndex = 0;
                else if (selectedBuild.Race.Equals("Protoss"))
                    RaceBox.SelectedIndex = 1;
                else if (selectedBuild.Race.Equals("Zerg"))
                    RaceBox.SelectedIndex = 2;

                if (selectedBuild.Versus.Equals("Terran"))
                    MatchupBox.SelectedIndex = 0;
                else if (selectedBuild.Versus.Equals("Protoss"))
                    MatchupBox.SelectedIndex = 1;
                else if (selectedBuild.Versus.Equals("Zerg"))
                    MatchupBox.SelectedIndex = 2;

                NameBox.Text = selectedBuild.Name;
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
            loadedBuildOrders = BuildReader.ReadFromBuildDirectory();
            PopulateBuildList();
        }

        /*******************************************************************************
         * Create Build
         * 
         *  - Saves current information into a new file in the 'builds' directory.
         * 
         *******************************************************************************/
        private bool CheckDuplicateBuildNames(string buildName)
        {
            foreach (Build B in loadedBuildOrders)
            {
                if (B.Name.Equals(buildName))
                    return false;
            }
            return true;
        }

        private bool ValidateBuildInputs(string name, string race, string match)
        {
            bool bNameCondition = (name != null && !name.Trim().Equals(""));
            bool bRaceCondition = (race.Equals("Terran") || race.Equals("Protoss") || race.Equals("Zerg"));
            bool bMatchCondition = (match.Equals("Terran") || match.Equals("Protoss") || match.Equals("Zerg"));

            return bNameCondition && bRaceCondition && bMatchCondition;
        }

        private void CreateBuild_Click(object sender, EventArgs e)
        {
            string sBuildName = NameBox.Text;
            string sBuildRace = RaceBox.Text;
            string sBuildMatchup = MatchupBox.Text;
            sBuildMatchup = sBuildMatchup.Replace("-vs- ", null);

            if (ValidateBuildInputs(sBuildName, sBuildRace, sBuildMatchup))
            {
                if (CheckDuplicateBuildNames(sBuildName))
                    BuildWriter.WriteToFile(new Build(sBuildName, sBuildRace + "-" + sBuildMatchup, new List<Step>(), sBuildName + ".txt"));
                else
                    MessageBox.Show(DUPLICATES_ERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(INVALID_ERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            loadedBuildOrders = BuildReader.ReadFromBuildDirectory();
            PopulateBuildList();
        }

        /*******************************************************************************
         * Delete Build File
         * 
         *  - Deletes selected Build from "builds" directory and list.
         * 
         *******************************************************************************/
        private void DeleteBuild_Click(object sender, EventArgs e)
        {
            if (selectedBuild != null)
            {
                ClearBuildEditor();
                File.Delete(selectedBuild.Filepath);

                loadedBuildOrders = BuildReader.ReadFromBuildDirectory();
                PopulateBuildList();
            }
            else
                MessageBox.Show(SELECTION_ERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        PopulateBuildEditor();

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
            e.NewWidth = BuildList.Columns[e.ColumnIndex].Width;
        }
    }
}
