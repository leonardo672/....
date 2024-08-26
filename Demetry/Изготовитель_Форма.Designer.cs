
namespace Demetry
{
    partial class Изготовитель_Форма
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
            this.изгDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.изгDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // изгDGV
            // 
            this.изгDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.изгDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.изгDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.изгDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.изгDGV.Location = new System.Drawing.Point(0, 19);
            this.изгDGV.Name = "изгDGV";
            this.изгDGV.RowHeadersWidth = 51;
            this.изгDGV.RowTemplate.Height = 24;
            this.изгDGV.Size = new System.Drawing.Size(800, 384);
            this.изгDGV.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 47);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 19);
            this.panel1.TabIndex = 33;
            // 
            // Изготовитель_Форма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.изгDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Изготовитель_Форма";
            this.Text = "Изготовитель_Форма";
            this.Load += new System.EventHandler(this.Изготовитель_Форма_Load);
            ((System.ComponentModel.ISupportInitialize)(this.изгDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView изгDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}