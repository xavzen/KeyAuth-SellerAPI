using Bunifu.UI.WinForms.Helpers.Transitions;
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
    public partial class VariablesTab : UserControl
    {

        string currentCell;

        public VariablesTab()
        {
            InitializeComponent();
        }

        private void removeVarBtn_Click(object sender, EventArgs e)
        {
            homeForm.sellerApi.VariableDelete(varDd.SelectedItem.ToString());
        }

        private void varDd_DropDown(object sender, EventArgs e)
        {
                foreach (var vars in homeForm.sellerApi.variables.All)
                {
                    varDd.Items.Add(vars.Varid);
                }
            }
           

        private void varDd_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void editVarBtn_Click(object sender, EventArgs e)
        {
            homeForm.sellerApi.VariableEdit(varDd.SelectedItem.ToString(), varMsgTb.Text);

            if (homeForm.sellerApi.response.Success)
            {
                MessageBox.Show(homeForm.sellerApi.response.Message);

            }
            else
            {
                MessageBox.Show(homeForm.sellerApi.response.Message);
            }
        }

        private void VariablesTab_Load(object sender, EventArgs e)
        {
            homeForm.sellerApi.VariableViewAll();
            if (homeForm.sellerApi.response.Success)
            {
                foreach (var vars in homeForm.sellerApi.variables.All)

                    vardatagrid.Rows.Insert(0, vars.Varid, vars.Msg);
            }
        }
    }                   
}
