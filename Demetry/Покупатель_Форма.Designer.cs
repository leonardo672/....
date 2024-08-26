
namespace Demetry
{
    partial class Покупатель_Форма
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
            this.ПокDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ПокDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ПокDGV
            // 
            this.ПокDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ПокDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ПокDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ПокDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ПокDGV.Location = new System.Drawing.Point(0, 0);
            this.ПокDGV.Name = "ПокDGV";
            this.ПокDGV.RowHeadersWidth = 51;
            this.ПокDGV.RowTemplate.Height = 24;
            this.ПокDGV.Size = new System.Drawing.Size(800, 403);
            this.ПокDGV.TabIndex = 35;
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
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 33;
            // 
            // Покупатель_Форма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ПокDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Покупатель_Форма";
            this.Text = "Покупатель_Форма";
            this.Load += new System.EventHandler(this.Покупатель_Форма_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ПокDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ПокDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}