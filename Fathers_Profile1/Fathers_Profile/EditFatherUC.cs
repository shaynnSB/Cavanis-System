using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fathers_Profile
{
    public partial class EditFatherUC : UserControl
    {
        public EditFatherUC()
        {
            InitializeComponent();
        }

        private void edit_Butt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edited profile.");
            ((Form)this.TopLevelControl).Close();
        }

        private void cancel_Butt_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure?", "Alert!", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                ((Form)this.TopLevelControl).Close();
            }
        }

        private void deadfatherCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (deadfatherCheck.Checked)
            {
                deathfBox.Enabled = true;
            }
            else
            {
                deathfBox.Enabled = false;
            }
        }

        private void deadmomCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (deadmomCheck.Checked)
            {
                deathmBox.Enabled = true;
            }
            else
            {
                deathmBox.Enabled = false;
            }
        }
        //siblings
        private void siblingCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (siblingCheck.Checked)
            {
                newSib_Butt.Enabled = false;
            }
            else
            {
                newSib_Butt.Enabled = true;
            }
        }

        private void newSib_Butt_Click(object sender, EventArgs e)
        {
            siblingPanel.Visible = true;
        }
        private void removeSibButt_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure?", "Alert!", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                //
            }
        }
        private void cancelButt_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure?", "Alert!", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                siblingPanel.Visible = false;
            }
        }

        private void oksButt_Click(object sender, EventArgs e)
        {
            siblingPanel.Visible = false;
        }
        //pictures
        private void upload_butt_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.png;)|*.jpg;*.jpeg;.*.gif; *.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                fatherPic.Image = new Bitmap(opnfd.FileName);
                fatherPic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void remove_butt_Click(object sender, EventArgs e)
        {
            fatherPic.Image = null;
        }

        private void upfamButt_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.png;)|*.jpg;*.jpeg;.*.gif; *.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                famPic.Image = new Bitmap(opnfd.FileName);
                famPic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void remfamButt_Click(object sender, EventArgs e)
        {
            famPic.Image = null;
        }

        private void uploadfButt_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.png;)|*.jpg;*.jpeg;.*.gif; *.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                dadPic.Image = new Bitmap(opnfd.FileName);
                dadPic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void removefButt_Click(object sender, EventArgs e)
        {
            dadPic.Image = null;
        }

        private void uploadmButt_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.png;)|*.jpg;*.jpeg;.*.gif; *.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                momPic.Image = new Bitmap(opnfd.FileName);
                momPic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void removemButt_Click(object sender, EventArgs e)
        {
            momPic.Image = null;
        }

        private void uploadsButt_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.png;)|*.jpg;*.jpeg;.*.gif; *.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                sibPic.Image = new Bitmap(opnfd.FileName);
                sibPic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void removesButt_Click(object sender, EventArgs e)
        {
            sibPic.Image = null;
        }
        //dates
        private void birthBox_Leave(object sender, EventArgs e)
        {
            if (!(birthBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                birthBox.Clear();
            }
        }

        private void semBox_Leave(object sender, EventArgs e)
        {
            if (!(semBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                semBox.Clear();
            }
        }

        private void frprofBox_Leave(object sender, EventArgs e)
        {
            if (!(frprofBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                frprofBox.Clear();
            }
        }

        private void prepBox_Leave(object sender, EventArgs e)
        {
            if (!(prepBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                prepBox.Clear();
            }
        }

        private void diaBox_Leave(object sender, EventArgs e)
        {
            if (!(diaBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                diaBox.Clear();
            }
        }

        private void priestBox_Leave(object sender, EventArgs e)
        {
            if (!(priestBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                priestBox.Clear();
            }
        }

        private void birthfBox_Leave(object sender, EventArgs e)
        {
            if (!(birthfBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                birthfBox.Clear();
            }
        }

        private void deathfBox_Leave(object sender, EventArgs e)
        {
            if (!(deathfBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                deathfBox.Clear();
            }
        }

        private void birthmBox_Leave(object sender, EventArgs e)
        {
            if (!(birthmBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                birthmBox.Clear();
            }
        }

        private void deathmBox_Leave(object sender, EventArgs e)
        {
            if (!(deathmBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                deathmBox.Clear();
            }
        }

        private void birthsBox_Leave(object sender, EventArgs e)
        {
            if (!(birthsBox.MaskCompleted))
            {
                MessageBox.Show("Invalid date.", "Alert!");
                birthsBox.Clear();
            }
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
