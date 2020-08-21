using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fathers_Profile
{
    public partial class FatherForm : Form
    {
        public FatherForm()
        {
            InitializeComponent();
        }

        private void new_Butt_Click(object sender, EventArgs e)
        {
            AddProfile formAdd = new AddProfile();
            formAdd.ShowDialog();   
        }

        private void edit_Butt_Click(object sender, EventArgs e)
        {
            EditFather formEdit = new EditFather();               
            formEdit.ShowDialog();
        }
    }
}
