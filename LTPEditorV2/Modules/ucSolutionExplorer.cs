using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.XtraBars.Demos.DockingDemo {
    public partial class ucSolutionExplorer : System.Windows.Forms.UserControl {
        public ucSolutionExplorer() {
            InitializeComponent();
            InitTreeView(treeView);
            treeView.CustomDrawNodeCell += treeView_CustomDrawNodeCell;
            treeView.AfterCollapse += treeView_AfterCollapse;
            treeView.AfterExpand += treeView_AfterExpand;
            AddAllNodes(iShow.Down);
        }
        public static void InitTreeView(DevExpress.XtraTreeList.TreeList treeView) {
            TreeListColumn column = treeView.Columns.Add();
            column.Visible = true;
            treeView.OptionsView.ShowColumns = false;
            treeView.OptionsView.ShowIndicator = false;
            treeView.OptionsView.ShowVertLines = false;
            treeView.OptionsView.ShowHorzLines = false;
            treeView.OptionsBehavior.Editable = false;
            treeView.OptionsSelection.EnableAppearanceFocusedCell = false;
        }
        void treeView_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e) {
            if(e.Node.Id == 1) 
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
        void SetIndex(TreeListNode node, int index, bool expand) {
            int newIndex = expand ? index - 1 : index + 1;
            if(node.StateImageIndex == index)
                node.StateImageIndex = newIndex;
        }
        void treeView_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e) {
            SetIndex(e.Node, 7, true);
            SetIndex(e.Node, 9, true);
        }
        void treeView_AfterCollapse(object sender, DevExpress.XtraTreeList.NodeEventArgs e) {
            SetIndex(e.Node, 6, false);
            SetIndex(e.Node, 8, false);
        }
        void AddAllNodes(bool showAll) {
            treeView.Nodes.Clear();
            treeView.AppendNode(new object[] { "Solution \'LTPEditorV2\' (1 of 1 project)" }, -1, -1, -1, 3); //0
            treeView.AppendNode(new object[] { "LTPEditorV2" }, -1, -1, -1, 4);//1
            treeView.AppendNode(new object[] { "Properties" }, 1, -1, -1, 2);//2
            treeView.AppendNode(new object[] { "References" }, 1, -1, -1, 5);//3
            treeView.AppendNode(new object[] { "System" }, 3, -1, -1, 5);
            treeView.AppendNode(new object[] { "System.Drawing" }, 3, -1, -1, 5);
            treeView.AppendNode(new object[] { "System.Windows.Forms" }, 3, -1, -1, 5);
            treeView.AppendNode(new object[] { "DevExpress.Utils" }, 3, -1, -1, 5);
            treeView.AppendNode(new object[] { "DevExpress.XtraBars" }, 3, -1, -1, 5);
            treeView.AppendNode(new object[] { "DevExpress.XtraEditors" }, 3, -1, -1, 5);
            if (showAll) {
                treeView.AppendNode(new object[] { "bin" }, 1, -1, -1, 9); //10
                treeView.AppendNode(new object[] { "Debug" }, 10, -1, -1, 9);
                treeView.AppendNode(new object[] { "Release" }, 10, -1, -1, 9);
                treeView.AppendNode(new object[] { "obj" }, 1, -1, -1, 9);//13
                treeView.AppendNode(new object[] { "Debug" }, 13, -1, -1, 9);
                treeView.AppendNode(new object[] { "Release" }, 13, -1, -1, 9);
            }
            treeView.AppendNode(new object[] { "Assets" }, 1, -1, -1, 7); //16/10
            treeView.AppendNode(new object[] { "Modules" }, 1, -1, -1, 7); //17/11
            treeView.AppendNode(new object[] { "Resources" }, 1, -1, -1, 7); //18/12
            treeView.AppendNode(new object[] { "AssemblyInfo.cs" }, 2, -1, -1, 10);
            treeView.AppendNode(new object[] { "licenses.licx" }, 2, -1, -1, 1);
            treeView.AppendNode(new object[] { "Resources.resx" }, 2, -1, -1, 1); //21
            treeView.AppendNode(new object[] { "Settings.settings" }, 2, -1, -1, 2); //22
            treeView.AppendNode(new object[] { "About.cs" }, 1, -1, -1, 11); //23
            treeView.AppendNode(new object[] { "App.config" }, 1, -1, -1, 2);
            treeView.AppendNode(new object[] { "MainForm.cs" }, 1, -1, -1, 11); //25
            treeView.AppendNode(new object[] { "Program.cs" }, 1, -1, -1, 10);
            treeView.AppendNode(new object[] { "icons8_visual_studio_16.png" }, showAll ? 16 : 10, -1, -1, 1);
            treeView.AppendNode(new object[] { "icons8_visual_studio_32.png" }, showAll ? 16 : 10, -1, -1, 1);
            treeView.AppendNode(new object[] { "Start-icon 16.png" }, showAll ? 16 : 10, -1, -1, 1);
            treeView.AppendNode(new object[] { "Start-icon 32.png" }, showAll ? 16 : 10, -1, -1, 1);
            treeView.AppendNode(new object[] { "Start.png" }, showAll ? 16 : 10, -1, -1, 1);
            treeView.AppendNode(new object[] { "visual_studio.ico" }, showAll ? 16 : 10, -1, -1, 3);
            treeView.AppendNode(new object[] { "visual_studio_30px.png" }, showAll ? 16 : 10, -1, -1, 1);
            treeView.AppendNode(new object[] { "visualstudio.ico" }, showAll ? 16 : 10, -1, -1, 3);
            treeView.AppendNode(new object[] { "ClassViewer.cs" }, showAll ? 17 : 11, -1, -1, 10);
            treeView.AppendNode(new object[] { "ucCodeEditor.cs" }, showAll ? 17 : 11, -1, -1, 12); //36
            treeView.AppendNode(new object[] { "ucOutput.cs" }, showAll ? 17 : 11, -1, -1, 12); //37
            treeView.AppendNode(new object[] { "ucProperties.cs" }, showAll ? 17 : 11, -1, -1, 12); //38
            treeView.AppendNode(new object[] { "ucSolutionExplorer.cs" }, showAll ? 17 : 11, -1, -1, 12); //39
            treeView.AppendNode(new object[] { "ucTaskList.cs" }, showAll ? 17 : 11, -1, -1, 12); //40
            treeView.AppendNode(new object[] { "ucToolbox.cs" }, showAll ? 17 : 11, -1, -1, 12); //41
            treeView.AppendNode(new object[] { "AppIcon.ico" }, showAll ? 18 : 12, -1, -1, 3);
            treeView.AppendNode(new object[] { "AssemblyInfo.rtf" }, showAll ? 18 : 12, -1, -1, 1);
            treeView.AppendNode(new object[] { "frmMain.rtf" }, showAll ? 18 : 12, -1, -1, 1);
            treeView.AppendNode(new object[] { "ProgramText.rtf" }, showAll ? 18 : 12, -1, -1, 1);
            treeView.AppendNode(new object[] { "ProgramText2.rtf" }, showAll ? 18 : 12, -1, -1, 1);
            treeView.AppendNode(new object[] { "ProgramText3.rtf" }, showAll ? 18 : 12, -1, -1, 1);
            treeView.AppendNode(new object[] { "SolutionExplorer.rtf" }, showAll ? 18 : 12, -1, -1, 1);
            treeView.AppendNode(new object[] { "splashScreen.png" }, showAll ? 18 : 12, -1, -1, 1);
            treeView.AppendNode(new object[] { "SplashScreenNew.png" }, showAll ? 18 : 12, -1, -1, 1);
            treeView.AppendNode(new object[] { "ucCodeEditor.rtf" }, showAll ? 18 : 12, -1, -1, 1);
            treeView.AppendNode(new object[] { "ucSolutionExplorer.rtf" }, showAll ? 18 : 12, -1, -1, 1);
            treeView.AppendNode(new object[] { "ucToolbox.rtf" }, showAll ? 18 : 12, -1, -1, 1);
            if (showAll) {
                treeView.AppendNode(new object[] { "Resources.Designer.cs" }, 21, -1, -1, 13);
                treeView.AppendNode(new object[] { "Settings.Designer.cs" }, 22, -1, -1, 13);
                treeView.AppendNode(new object[] { "About.Designer.cs" }, 23, -1, -1, 13);
                treeView.AppendNode(new object[] { "About.resx" }, 23, -1, -1, 13);
                treeView.AppendNode(new object[] { "MainForm.Designer.cs" }, 25, -1, -1, 13);
                treeView.AppendNode(new object[] { "MainForm.resx" }, 25, -1, -1, 13);               
                treeView.AppendNode(new object[] { "ucCodeEditor.Designer.cs" }, 36, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucCodeEditor.resx" }, 36, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucOutput.Designer.cs" }, 37, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucOutput.resx" }, 37, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucProperties.Designer.cs" }, 38, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucProperties.resx" }, 38, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucSolutionExplorer.Designer.cs" }, 39, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucSolutionExplorer.resx" }, 39, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucTaskList.Designer.cs" }, 40, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucTaskList.resx" }, 40, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucToolbox.Designer.cs" }, 41, -1, -1, 13);
                treeView.AppendNode(new object[] { "ucToolbox.resx" }, 41, -1, -1, 13);
            }
            treeView.ExpandAll();
        }
        public event EventHandler PropertiesItemClick;
        void iShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddAllNodes(((DevExpress.XtraBars.BarButtonItem)e.Item).Down);
        }
        void iProperties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(PropertiesItemClick != null)
                PropertiesItemClick(sender, EventArgs.Empty);
        }
        public event EventHandler TreeViewItemClick;
        void treeView_MouseDoubleClick(object sender, MouseEventArgs e) {
            if(TreeViewItemClick != null)
                TreeViewItemClick(sender, EventArgs.Empty);
        }
    }
}
