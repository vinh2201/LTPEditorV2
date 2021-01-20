using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraBars.Demos.DockingDemo {
    public partial class ucOutput : XtraUserControl {
        public ucOutput() {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
            textBox.ContextMenuStrip = new ContextMenuStrip();
        }
        void comboBox_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(comboBox.SelectedIndex == 0)
                textBox.Text = " ------ Build started: Project: LTPEditorV2, Configuration: Debug .NET ------\r\n\r\n Preparing resources...\r\n Updating references...\r\n Performing main compilation...\r\n\r\n Build complete -- 0 errors, 0 warnings\r\n Building satellite assemblies...\r\n\r\n\r\n ---------------------- Done ----------------------\r\n\r\n     Build: 1 succeeded, 0 failed, 0 skipped";
            else textBox.Text = " 'DefaultDomain': Loaded 'C:\\winnt\\microsoft.net\\framework\\v1.0.3705\\mscorlib.dll', No symbols loaded.\r\n 'LTPEditorV2': Loaded 'C:\\Users\\ltpnt\\source\\repos\\LTPEditorV2\\LTPEditorV2\\bin\\Debug\\LTPEditorV2.exe', Symbols loaded.";
        }
        void textBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            e.Handled = true;
        }
    }
}
