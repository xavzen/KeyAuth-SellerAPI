using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xavHub.Controls
{
    public partial class FilesTab : UserControl
    {
        int FileId = 0;
        public FilesTab()
        {
            InitializeComponent();
        }

        private void FilesView_Load(object sender, EventArgs e)
        {
            homeForm.sellerApi.FileViewAll();
            if (homeForm.sellerApi.response.Success)
            {
                foreach (var Files in homeForm.sellerApi.files.All)
                bunifuDataGridView1.Rows.Insert(0, Files.Id, Files.Url);
                bunifuDataGridView1.Columns[0].Width = 68;
                bunifuDataGridView1.Columns[1].Width = 650;
            }
            else if (homeForm.sellerApi.response.Message.Contains("No application with specified seller key found"))
            {
              
            }
        
        }
    }
}

