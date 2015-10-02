using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace LibManDA
{
    partial class Container
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

            this.bookGridView = new System.Windows.Forms.DataGridView
            {
                Dock = DockStyle.Fill
            };

            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).BeginInit();
            this.SuspendLayout();
            //
            // tablePanel
            //
            // 
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2
            };
            tablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            // bookGridView
            //             
            this.bookGridView.Location = new System.Drawing.Point(32, 35);          
            this.bookGridView.Name = "bookGridView";
            this.bookGridView.TabIndex = 0;
            this.bookGridView.MouseClick += bookGridView_MouseClick;
            this.bookGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.bookGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.bookGridView.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.bookGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;            

            this.bookGridView.DefaultCellStyle.SelectionBackColor = Color.Brown;
            this.bookGridView.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            this.bookGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //Logo
            //
            logo = new PictureBox
            {
                Dock = DockStyle.Fill
            };
                        
            logo.Image = Properties.Resources.logo;
            tablePanel.Controls.Add(logo, 0, 0);
            // Container
            //                         
            tablePanel.Controls.Add(bookGridView, 0, 1);            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tablePanel);
            this.Name = "Container";
            this.Text = "Simple Library Management";            
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
        private System.Windows.Forms.DataGridView bookGridView;
        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private PictureBox logo;
    }
}

