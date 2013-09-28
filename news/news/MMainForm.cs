using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace news
{
    public partial class MMainForm : Form
    {
        public MMainForm()
        {
            InitializeComponent();
        }

        private void btnAddClientName_Click(object sender, EventArgs e)
        {
            MClientManagerForm clientManagerForm = new MClientManagerForm();
            clientManagerForm.ShowDialog();
        }

        private void btnManageNews_Click(object sender, EventArgs e)
        {
            MNewsManagerForm newsManagerForm = new MNewsManagerForm();
            newsManagerForm.ShowDialog();
        }

        private void btnManageImage_Click(object sender, EventArgs e)
        {
            MImageManagerForm imageManagerForm = new MImageManagerForm();
            imageManagerForm.ShowDialog();
        }

        private void btnAppUIManager_Click(object sender, EventArgs e)
        {
            MAppUIManagerForm appUIManagerForm = new MAppUIManagerForm();
            appUIManagerForm.ShowDialog();
        }

        private void btnManagerTaobaoke_Click(object sender, EventArgs e)
        {
            ManageProductForm manageProductForm = new ManageProductForm();
            manageProductForm.ShowDialog();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            HttpWebRequest myRequest =
          (HttpWebRequest)WebRequest.Create(MShareDataManager.gInstance.mServerUrl + "ClearData?categoryId=" +MShareDataManager.gInstance.mCategoryID );
            myRequest.Method = "GET";
            myRequest.ContentType = "text/html;charset=gb2312";
            myRequest.GetResponse();
        }
    }
}
