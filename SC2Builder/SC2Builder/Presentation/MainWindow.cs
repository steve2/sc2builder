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
using SC2Builder.Model;

namespace SC2Builder
{
	public partial class MainWindow : Form
	{

		public const string DUPLICATES_ERROR = "Error: Build already exists with this name.";
		public const string SELECTION_ERROR = "Error: No build is currently selected.";
		public const string INVALID_ERROR = "Error: Build contains invalid information.";

		public const string TERRAN = "Terran";
		public const string PROTOSS = "Protoss";
		public const string ZERG = "Zerg";

		public Dictionary<String, int> imageLookupTable;

		private List<Build> LoadedBuildOrders;
		private Build SelectedBuild;
		private bool bBuildListSortedByRace;
		private bool bBuildListSortedByMatchup;

		private SortBuildsOrder SortByRaceIndex;
		private SortBuildsOrder SortByMatchupIndex;


		/********************************  ********************************/

		public MainWindow()
		{
			imageLookupTable = new Dictionary<string, int>();
			InitImageLookupTable.Init(imageLookupTable);

			LoadedBuildOrders = new List<Build>();
			SelectedBuild = null;

			bBuildListSortedByRace = false;
			bBuildListSortedByMatchup = false;
			SortByRaceIndex = (SortBuildsOrder)0;
			SortByMatchupIndex = (SortBuildsOrder)0;

			SplashWindow splashScreen = new SplashWindow();
			Application.Run(splashScreen);

			InitializeComponent();
		}


		/******************************** Loading & Exiting ********************************/

		private void MainWindow_Load(object sender, EventArgs e)
		{
			LoadedBuildOrders = BuildReader.ReadFromBuildDirectory();
			PopulateBuildList(LoadedBuildOrders);
		}

		private void BuildList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			e.Cancel = true;
			e.NewWidth = BuildList.Columns[e.ColumnIndex].Width;
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
		/******************************** Sorting ********************************/

		enum SortBuildsOrder
		{ /* Enumeration of permutations for Terran/Protoss/Zerg ordering */
			T_P_Z=0, T_Z_P=1, P_T_Z=2, P_Z_T=3, Z_P_T=4, Z_T_P=5
		};

		private List<Build> GetBuildsByRace(List<Build> builds, string race)
		{
			List<Build> byRace = new List<Build>();
			foreach (Build B in builds)
			{
				if (B.Race.Equals(race))
					byRace.Add(B);
			}
			return byRace;
		}

		private List<Build> GetBuildsByMatchup(List<Build> builds, string matchup)
		{
			List<Build> byMatch = new List<Build>();
			foreach (Build B in builds)
			{
				if (B.Versus.Equals(matchup))
					byMatch.Add(B);
			}
			return byMatch;
		}

		private List<Build> GetSortedBuildsByRace(List<Build> builds, SortBuildsOrder sortInOrder)
		{
			List<Build> sortedBuilds = new List<Build>();
			switch (sortInOrder)
			{
				case SortBuildsOrder.T_P_Z:
					sortedBuilds.AddRange(GetBuildsByRace(builds, TERRAN));
					sortedBuilds.AddRange(GetBuildsByRace(builds, PROTOSS));
					sortedBuilds.AddRange(GetBuildsByRace(builds, ZERG));
					break;
				case SortBuildsOrder.T_Z_P:
					sortedBuilds.AddRange(GetBuildsByRace(builds, TERRAN));
					sortedBuilds.AddRange(GetBuildsByRace(builds, ZERG));
					sortedBuilds.AddRange(GetBuildsByRace(builds, PROTOSS));
					break;
				case SortBuildsOrder.P_T_Z:
					sortedBuilds.AddRange(GetBuildsByRace(builds, PROTOSS));
					sortedBuilds.AddRange(GetBuildsByRace(builds, TERRAN));
					sortedBuilds.AddRange(GetBuildsByRace(builds, ZERG));
					break;
				case SortBuildsOrder.P_Z_T:
					sortedBuilds.AddRange(GetBuildsByRace(builds, PROTOSS));
					sortedBuilds.AddRange(GetBuildsByRace(builds, ZERG));
					sortedBuilds.AddRange(GetBuildsByRace(builds, TERRAN));
					break;
				case SortBuildsOrder.Z_T_P:
					sortedBuilds.AddRange(GetBuildsByRace(builds, ZERG));
					sortedBuilds.AddRange(GetBuildsByRace(builds, TERRAN));
					sortedBuilds.AddRange(GetBuildsByRace(builds, PROTOSS));
					break;
				case SortBuildsOrder.Z_P_T:
					sortedBuilds.AddRange(GetBuildsByRace(builds, ZERG));
					sortedBuilds.AddRange(GetBuildsByRace(builds, PROTOSS));
					sortedBuilds.AddRange(GetBuildsByRace(builds, TERRAN));
					break;
			}
			return sortedBuilds;
		}

		private List<Build> GetSortedBuildsByMatchup(List<Build> builds, SortBuildsOrder sortInOrder)
		{
			List<Build> sortedBuilds = new List<Build>();
			switch (sortInOrder)
			{
				case SortBuildsOrder.T_P_Z:
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, TERRAN));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, PROTOSS));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, ZERG));
					break;
				case SortBuildsOrder.T_Z_P:
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, TERRAN));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, ZERG));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, PROTOSS));
					break;
				case SortBuildsOrder.P_T_Z:
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, PROTOSS));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, TERRAN));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, ZERG));
					break;
				case SortBuildsOrder.P_Z_T:
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, PROTOSS));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, ZERG));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, TERRAN));
					break;
				case SortBuildsOrder.Z_T_P:
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, ZERG));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, TERRAN));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, PROTOSS));
					break;
				case SortBuildsOrder.Z_P_T:
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, ZERG));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, PROTOSS));
					sortedBuilds.AddRange(GetBuildsByMatchup(builds, TERRAN));
					break;
			}
			return sortedBuilds;
		}


		/******************************** User Interface Utilities ********************************/
		
		private void RefreshBuildData()
		{
			LoadedBuildOrders = BuildReader.ReadFromBuildDirectory();
			if (bBuildListSortedByRace)
			{
				PopulateBuildList(GetSortedBuildsByRace(LoadedBuildOrders, SortByRaceIndex));
			}
			else if (bBuildListSortedByMatchup)
			{
				PopulateBuildList(GetSortedBuildsByMatchup(LoadedBuildOrders, SortByMatchupIndex));
			}
			else
			{
				PopulateBuildList(LoadedBuildOrders);
			}
			if (SelectedBuild == null)
				if (LoadedBuildOrders.Count > 0)
					SelectedBuild = LoadedBuildOrders[0];
			PopulateStepList(SelectedBuild);
			PopulateBuildEditor(SelectedBuild);
			ReSelectBuildInList();
			BuildList.Select();
		}

		/** Can be useful to ReSelect when we sort or perform an operation 
			that alters the contents of the ListView (of Builds). */
		private void ReSelectBuildInList()
		{
			if (SelectedBuild != null)
				BuildList.Items[FindBuildInList(SelectedBuild)].Selected = true;
		}

		private int FindBuildInList(Build build)
		{
			int i, stop = BuildList.Items.Count;
			for (i = 0; i < stop; i++)
			{
				if (BuildList.Items[i].Text.Equals(build.Name))
					return i;
			}
			return -1;
		}

		private void PopulateBuildList(List<Build> builds)
		{
			BuildList.Items.Clear();
			foreach (Build B in builds)
			{
				ListViewItem buildItem = new ListViewItem(B.Name);
				 buildItem.SubItems.Add(B.Race);
				 buildItem.SubItems.Add("vs. " + B.Versus);

				if (B.Race.Equals(TERRAN))
					buildItem.ImageIndex = imageLookupTable["icon-terran-small"];
				else if (B.Race.Equals(PROTOSS))
					buildItem.ImageIndex = imageLookupTable["icon-protoss-small"];
				else if (B.Race.Equals(ZERG))
					buildItem.ImageIndex = imageLookupTable["icon-zerg-small"];

				BuildList.Items.Add(buildItem);
			}
		}

		private void PopulateStepList(Build build)
		{
			StepList.Items.Clear();
			if (build != null)
			{
				foreach (Step S in build.Steps)
				{
					ListViewItem stepItem = new ListViewItem(S.ToString());
					if (build.Race.Equals(TERRAN))
						stepItem.ImageIndex = imageLookupTable["icon-terran-supply"];
					else if (build.Race.Equals(PROTOSS))
						stepItem.ImageIndex = imageLookupTable["icon-protoss-supply"];
					else if (build.Race.Equals(ZERG))
						stepItem.ImageIndex = imageLookupTable["icon-zerg-supply"];
					StepList.Items.Add(stepItem);
				}
			}
		}

		private void PopulateBuildEditor(Build build)
		{
			if (build != null)
			{
				if (build.Race.Equals(TERRAN))
					RaceBox.SelectedIndex = 0;
				else if (build.Race.Equals(PROTOSS))
					RaceBox.SelectedIndex = 1;
				else if (build.Race.Equals(ZERG))
					RaceBox.SelectedIndex = 2;

				if (build.Versus.Equals(TERRAN))
					MatchupBox.SelectedIndex = 0;
				else if (build.Versus.Equals(PROTOSS))
					MatchupBox.SelectedIndex = 1;
				else if (build.Versus.Equals(ZERG))
					MatchupBox.SelectedIndex = 2;

				NameBox.Text = build.Name;

				BuildSpecTextBox.Text = "";
				foreach (Step S in build.Steps)
					BuildSpecTextBox.Text = BuildSpecTextBox.Text + (S.RawString()) + "\n";
			}
		}

		private void ClearBuildEditor()
		{
			RaceBox.SelectedIndex = -1;
			MatchupBox.SelectedIndex = -1;
			NameBox.Text = null;
			BuildSpecTextBox.Text = null;
		}



		/******************************** Input Validation ********************************/

		private bool CheckDuplicateBuildNames(string buildName)
		{
			foreach (Build B in LoadedBuildOrders)
			{
				if (B.Name.Equals(buildName))
					return false;
			}
			return true;
		}




		/******************************** User Interface Events ********************************/


		/************************************************************************************************************
		 *
		 *	Sort Builds
		 *
		 ************************************************************************************************************/
		private void BuildList_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			const int RACE_COL = 1, MATCH_COL = 2;
			List<Build> buildsSorted;

			switch (e.Column)
			{
				/** Sort Build List By Race **/
				case RACE_COL:
					bBuildListSortedByRace = true;
					bBuildListSortedByMatchup = false;

					buildsSorted = GetSortedBuildsByRace(LoadedBuildOrders, SortByRaceIndex);
					SortByRaceIndex += 1;
					if (SortByRaceIndex > SortBuildsOrder.Z_T_P)
						SortByRaceIndex = SortBuildsOrder.T_P_Z;
					PopulateBuildList(buildsSorted);
					ReSelectBuildInList();
					break;

				/** Sort Build List By Matchup **/
				case MATCH_COL:
					bBuildListSortedByMatchup = true;
					bBuildListSortedByRace = false;

					buildsSorted = GetSortedBuildsByMatchup(LoadedBuildOrders, SortByMatchupIndex);
					SortByMatchupIndex += 1;
					if (SortByMatchupIndex > SortBuildsOrder.Z_T_P)
						SortByMatchupIndex = SortBuildsOrder.T_P_Z;
					PopulateBuildList(buildsSorted);
					ReSelectBuildInList();
					break;
			}
		}

		/************************************************************************************************************
		 *
		 *	Create Build 
		 *
		 ************************************************************************************************************/
		private void CreateBuild_Click(object sender, EventArgs e)
		{
			EditorContents editContent = new EditorContents(NameBox.Text, RaceBox.Text, MatchupBox.Text.Replace("-vs-", null), BuildSpecTextBox.Text);

			if (editContent.ContentIsValid())
			{
				if (CheckDuplicateBuildNames(editContent.Name))
				{
					SelectedBuild = editContent.ToBuild();
					BuildWriter.WriteToFile(SelectedBuild);
					RefreshBuildData();
				}
				else
					MessageBox.Show(DUPLICATES_ERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				MessageBox.Show(INVALID_ERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/************************************************************************************************************
		 *
		 *	Update Selected Build 
		 *
		 ************************************************************************************************************/
		private void UpdateBuild_Click(object sender, EventArgs e)
		{
			EditorContents editContent = new EditorContents(NameBox.Text, RaceBox.Text, MatchupBox.Text.Replace("-vs-", null), BuildSpecTextBox.Text);

			if (editContent.ContentIsValid() && SelectedBuild != null)
			{
				File.Delete(SelectedBuild.Filepath);
				SelectedBuild = editContent.ToBuild();
				BuildWriter.WriteToFile(SelectedBuild);
				RefreshBuildData();
			}
			else
				MessageBox.Show(INVALID_ERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/************************************************************************************************************
		 *
		 *	Delete Selected Build
		 *
		 ************************************************************************************************************/
		private void DeleteBuild_Click(object sender, EventArgs e)
		{
			if (SelectedBuild != null)
			{
				if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
				{
					File.Delete(SelectedBuild.Filepath);
					SelectedBuild = null;
					RefreshBuildData();
				}
			}
			else
				MessageBox.Show(SELECTION_ERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/************************************************************************************************************
		 *
		 *	Change Build Selection (SelectedBuild)	
		 *
		 ************************************************************************************************************/
		private void BuildList_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection selected = BuildList.SelectedItems;
			SelectedBuild = null;
			if (selected.Count > 0)
			{
				foreach (Build B in LoadedBuildOrders)
				{
					if (B.Equals(selected[0].Text))
					{
						this.SelectedBuild = B;
						PopulateStepList(this.SelectedBuild);
						PopulateBuildEditor(this.SelectedBuild);
						break;
					}
				}
			}
			else
			{
				PopulateStepList(null);
				ClearBuildEditor();
			}
		}

		/************************************************************************************************************
		 *
		 *	Load External Build File
		 *
		 ************************************************************************************************************/
		private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "txt files (*.txt)|*.txt";
			ofd.FilterIndex = 1;
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				Build read = BuildReader.ReadFromFile(ofd.FileName);
				BuildWriter.WriteToFile(read);
				LoadedBuildOrders = BuildReader.ReadFromBuildDirectory();

				PopulateBuildList(LoadedBuildOrders);
				PopulateStepList(read); //we don't need to add the Build to the BuildList yet.
				PopulateBuildEditor(read); // ^^

				SelectedBuild = read;
				ReSelectBuildInList();
			}
		}
	}
}
