using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL.Implement.CPE_vs1DAL;

namespace CPE_vs1
{
    public partial class Agent : DevExpress.XtraEditors.XtraForm
    {
        IAgentsDAL AgentDAl=new AgentsDAL();
        Models.Agent agentCur = new Models.Agent();
        void GetAgentPromGrid()
        {
            agentCur = (Models.Agent)gridViewAgent.GetFocusedRow();
            txtAddress.Text = agentCur.Address;
            txtcontact.Text = agentCur.Contact;
            txtEmail.Text = agentCur.Email;
            txtName.Text = agentCur.Name;
            SpinCode.EditValue = Convert.ToDecimal( agentCur.Code);
        }
        void ClearControl()
        {
            agentCur = new Models.Agent();
            txtName.Text = "";
            txtEmail.Text = "";
            txtcontact.Text = "";
            txtAddress.Text = "";
            SpinCode.EditValue = 0;
        }
        void GetAgentFromControl()
        {
            agentCur.Address = txtAddress.Text;
            agentCur.Code = SpinCode.EditValue.ToString();
            agentCur.Contact = txtcontact.Text;
            agentCur.Email = txtEmail.Text;
            agentCur.Name = txtName.Text;
        }

        void GetAllAgent()
        {
            GridAgent.DataSource = AgentDAl.SelectAll();
        }
        void InsertAgent()
        {
            GetAgentFromControl();
            AgentDAl.Insert(agentCur);
        }
        void UpdateAgent()
        {
            GetAgentFromControl();
            AgentDAl.Update(agentCur);
        }
        public Agent()
        {
            InitializeComponent();
        }

        private void Agent_Load(object sender, EventArgs e)
        {
            GetAllAgent();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (valid.Validate())
            {
                if (agentCur.ID == 0)
                {
                    InsertAgent();
                }
                else
                {
                    UpdateAgent();
                }
                GetAllAgent();
                ClearControl();
            }
        }

        private void GridAgent_DoubleClick(object sender, EventArgs e)
        {
            GetAgentPromGrid();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                agentCur = (Models.Agent)gridViewAgent.GetFocusedRow();
                AgentDAl.DeleteByID(agentCur.ID);
                GetAllAgent();
            }
        }

        private void SpinCode_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
        }

        private void SpinCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}