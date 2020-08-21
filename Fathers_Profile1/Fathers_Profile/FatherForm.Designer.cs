namespace Fathers_Profile
{
    partial class FatherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.father_Grid = new System.Windows.Forms.DataGridView();
            this.search_butt = new System.Windows.Forms.Button();
            this.ref_butt = new System.Windows.Forms.Button();
            this.new_Butt = new System.Windows.Forms.Button();
            this.edit_Butt = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.infoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fatherInfoUC1 = new Fathers_Profile.FatherInfoUC();
            ((System.ComponentModel.ISupportInitialize)(this.father_Grid)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // father_Grid
            // 
            this.father_Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.father_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.father_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.father_Grid.Location = new System.Drawing.Point(31, 111);
            this.father_Grid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.father_Grid.Name = "father_Grid";
            this.father_Grid.RowHeadersWidth = 51;
            this.father_Grid.RowTemplate.Height = 24;
            this.father_Grid.Size = new System.Drawing.Size(290, 477);
            this.father_Grid.TabIndex = 0;
            // 
            // search_butt
            // 
            this.search_butt.BackColor = System.Drawing.Color.DarkCyan;
            this.search_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.search_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_butt.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_butt.ForeColor = System.Drawing.SystemColors.Control;
            this.search_butt.Location = new System.Drawing.Point(242, 41);
            this.search_butt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_butt.Name = "search_butt";
            this.search_butt.Size = new System.Drawing.Size(37, 30);
            this.search_butt.TabIndex = 1;
            this.search_butt.Text = "S";
            this.search_butt.UseVisualStyleBackColor = false;
            // 
            // ref_butt
            // 
            this.ref_butt.BackColor = System.Drawing.Color.DarkCyan;
            this.ref_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ref_butt.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ref_butt.ForeColor = System.Drawing.SystemColors.Control;
            this.ref_butt.Location = new System.Drawing.Point(284, 41);
            this.ref_butt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ref_butt.Name = "ref_butt";
            this.ref_butt.Size = new System.Drawing.Size(37, 30);
            this.ref_butt.TabIndex = 2;
            this.ref_butt.Text = "R";
            this.ref_butt.UseVisualStyleBackColor = false;
            // 
            // new_Butt
            // 
            this.new_Butt.BackColor = System.Drawing.Color.DarkCyan;
            this.new_Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_Butt.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Butt.ForeColor = System.Drawing.SystemColors.Control;
            this.new_Butt.Location = new System.Drawing.Point(30, 79);
            this.new_Butt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.new_Butt.Name = "new_Butt";
            this.new_Butt.Size = new System.Drawing.Size(97, 28);
            this.new_Butt.TabIndex = 3;
            this.new_Butt.Text = "Add";
            this.new_Butt.UseVisualStyleBackColor = false;
            this.new_Butt.Click += new System.EventHandler(this.new_Butt_Click);
            // 
            // edit_Butt
            // 
            this.edit_Butt.BackColor = System.Drawing.Color.DarkCyan;
            this.edit_Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_Butt.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_Butt.ForeColor = System.Drawing.SystemColors.Control;
            this.edit_Butt.Location = new System.Drawing.Point(141, 79);
            this.edit_Butt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edit_Butt.Name = "edit_Butt";
            this.edit_Butt.Size = new System.Drawing.Size(97, 28);
            this.edit_Butt.TabIndex = 4;
            this.edit_Butt.Text = "Edit";
            this.edit_Butt.UseVisualStyleBackColor = false;
            this.edit_Butt.Click += new System.EventHandler(this.edit_Butt_Click);
            // 
            // search_box
            // 
            this.search_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_box.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(30, 41);
            this.search_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(208, 30);
            this.search_box.TabIndex = 5;
            // 
            // infoPanel
            // 
            this.infoPanel.AutoScroll = true;
            this.infoPanel.Controls.Add(this.fatherInfoUC1);
            this.infoPanel.Location = new System.Drawing.Point(353, 41);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(754, 548);
            this.infoPanel.TabIndex = 6;
            // 
            // fatherInfoUC1
            // 
            this.fatherInfoUC1.BackColor = System.Drawing.Color.DarkCyan;
            this.fatherInfoUC1.Enabled = false;
            this.fatherInfoUC1.Location = new System.Drawing.Point(3, 3);
            this.fatherInfoUC1.Name = "fatherInfoUC1";
            this.fatherInfoUC1.Size = new System.Drawing.Size(731, 1415);
            this.fatherInfoUC1.TabIndex = 0;
            // 
            // FatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 654);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.edit_Butt);
            this.Controls.Add(this.new_Butt);
            this.Controls.Add(this.ref_butt);
            this.Controls.Add(this.search_butt);
            this.Controls.Add(this.father_Grid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Cavanis Fathers";
            ((System.ComponentModel.ISupportInitialize)(this.father_Grid)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView father_Grid;
        private System.Windows.Forms.Button search_butt;
        private System.Windows.Forms.Button ref_butt;
        private System.Windows.Forms.Button new_Butt;
        private System.Windows.Forms.Button edit_Butt;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.FlowLayoutPanel infoPanel;
        private FatherInfoUC fatherInfoUC1;
    }
}

