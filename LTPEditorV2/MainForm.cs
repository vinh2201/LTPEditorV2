using DevExpress.XtraBars.Helpers;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTPEditorV2
{
    public partial class MainForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            SkinHelper.InitSkinPopupMenu(barLinkContainerItem1);
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var me = new ProcessStartInfo("chrome.exe");
            me.Arguments = "https://github.com/intiu/LTPEditorV2";
            Process.Start(me);
        }

        private void OpenDlg()
        {
            OpenFileDialog of = new OpenFileDialog();
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
                of.Filter = "C# File|*.cs|Any File|*.*";
            else of.Filter = "Any File|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                fastColoredTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = of.FileName;
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenDlg();          
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenDlg();
        }

        private void SaveDlg()
        {
            SaveFileDialog of = new SaveFileDialog();
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
                of.Filter = "C# File|*.cs|Any File|*.*";
            else of.Filter = "Any File|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(of.FileName);
                sr.Write(fastColoredTextBox1.Text);
                sr.Close();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.Text);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
            catch
            {
                SaveDlg();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.Text);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
            catch
            {
                SaveDlg();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveDlg();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveDlg();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Print();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Print();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Redo();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Redo();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.ShowGoToDialog();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FontDialog cd = new FontDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Font = cd.Font;
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FontDialog cd = new FontDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Font = cd.Font;
            }
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.ForeColor = cd.Color;
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.ForeColor = cd.Color;
            }
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.BackColor = cd.Color;
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.BackColor = cd.Color;
            }
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Executable File|*.exe";
                string OutPath = "?.exe";

                OutPath = sf.FileName;

                //compile code:
                //create c# code compiler
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                //create new parameters for compilation and add references(libs) to compiled app
                CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll" });
                //is compiled code will be executable?(.exe)
                parameters.GenerateExecutable = true;
                //output path
                parameters.OutputAssembly = OutPath;
                //code sources to compile
                string[] sources = { fastColoredTextBox1.Text };
                //results of compilation
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, sources);

                //if has errors
                if (results.Errors.Count > 0)
                {
                    string errsText = "";
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        errsText = "(" + CompErr.ErrorNumber +
                                    ")Line " + CompErr.Line +
                                    ",Column " + CompErr.Column +
                                    ":" + CompErr.ErrorText + "" +
                                    Environment.NewLine;
                    }
                    //show error message
                    //MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Build complete and No Error");
                }
            }
            else
            {
                MessageBox.Show("Can't Build this file");
            }
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Executable File|*.exe";
                string OutPath = "?.exe";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    OutPath = sf.FileName;
                }
                //compile code:
                //create c# code compiler
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                //create new parameters for compilation and add references(libs) to compiled app
                CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll" });
                //is compiled code will be executable?(.exe)
                parameters.GenerateExecutable = true;
                //output path
                parameters.OutputAssembly = OutPath;
                //code sources to compile
                string[] sources = { fastColoredTextBox1.Text };
                //results of compilation
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, sources);

                //if has errors
                if (results.Errors.Count > 0)
                {
                    string errsText = "";
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        errsText = "(" + CompErr.ErrorNumber +
                                    ")Line " + CompErr.Line +
                                    ",Column " + CompErr.Column +
                                    ":" + CompErr.ErrorText + "" +
                                    Environment.NewLine;
                    }
                    //show error message
                    MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //run compiled app
                    System.Diagnostics.Process.Start(OutPath);
                }

            }
            else
            {
                MessageBox.Show("Can't Run this file");
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Executable File|*.exe";
                string OutPath = "?.exe";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    OutPath = sf.FileName;
                }
                //compile code:
                //create c# code compiler
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                //create new parameters for compilation and add references(libs) to compiled app
                CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll" });
                //is compiled code will be executable?(.exe)
                parameters.GenerateExecutable = true;
                //output path
                parameters.OutputAssembly = OutPath;
                //code sources to compile
                string[] sources = { fastColoredTextBox1.Text };
                //results of compilation
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, sources);

                //if has errors
                if (results.Errors.Count > 0)
                {
                    string errsText = "";
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        errsText = "(" + CompErr.ErrorNumber +
                                    ")Line " + CompErr.Line +
                                    ",Column " + CompErr.Column +
                                    ":" + CompErr.ErrorText + "" +
                                    Environment.NewLine;
                    }
                    //show error message
                    MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //run compiled app
                    System.Diagnostics.Process.Start(OutPath);
                }

            }
            else
            {
                MessageBox.Show("Can't Run this file");
            }
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            About about = new About();
            //this.Hide();
            about.Show();
            this.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            About about = new About();
            //this.Hide();
            about.Show();
            this.Show();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
