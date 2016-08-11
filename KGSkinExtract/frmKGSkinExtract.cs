using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace KugouSkinRead
{
    public partial class frmKGSkinExtract : Form
    {
        public String FileName;
        public String SavePath; 
        public frmKGSkinExtract()
        {
            InitializeComponent();
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                SavePath = fd.SelectedPath;
                txtSavePath.Text = SavePath;               
            }
        }

        private void btnResFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FileName = fd.FileName;
                txtResFile.Text = FileName;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            ResExtract re = new ResExtract();

            re.clear();
            re.LoadFromFile(txtResFile.Text);
            re.ExtractAll(txtSavePath.Text);
            re.Destroy();

            MessageBox.Show("资源提取完成!");
        }
    }
}
