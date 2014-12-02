namespace AppCashflow
{
    partial class Fresultat
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlCashFlow = new System.Windows.Forms.TabControl();
            this.tabCash1 = new System.Windows.Forms.TabPage();
            this.tabCashActu = new System.Windows.Forms.TabPage();
            this.tabConclusion = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.titres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlCashFlow.SuspendLayout();
            this.tabCash1.SuspendLayout();
            this.tabCashActu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(219, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Résultat de la simulation";
            // 
            // tabControlCashFlow
            // 
            this.tabControlCashFlow.Controls.Add(this.tabCash1);
            this.tabControlCashFlow.Controls.Add(this.tabCashActu);
            this.tabControlCashFlow.Controls.Add(this.tabConclusion);
            this.tabControlCashFlow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tabControlCashFlow.Location = new System.Drawing.Point(25, 83);
            this.tabControlCashFlow.Name = "tabControlCashFlow";
            this.tabControlCashFlow.SelectedIndex = 0;
            this.tabControlCashFlow.Size = new System.Drawing.Size(593, 300);
            this.tabControlCashFlow.TabIndex = 1;
            // 
            // tabCash1
            // 
            this.tabCash1.Controls.Add(this.dataGridView1);
            this.tabCash1.Location = new System.Drawing.Point(4, 24);
            this.tabCash1.Name = "tabCash1";
            this.tabCash1.Padding = new System.Windows.Forms.Padding(3);
            this.tabCash1.Size = new System.Drawing.Size(585, 272);
            this.tabCash1.TabIndex = 0;
            this.tabCash1.Text = "Cash-Flow";
            this.tabCash1.UseVisualStyleBackColor = true;
            // 
            // tabCashActu
            // 
            this.tabCashActu.Controls.Add(this.dataGridView2);
            this.tabCashActu.Location = new System.Drawing.Point(4, 24);
            this.tabCashActu.Name = "tabCashActu";
            this.tabCashActu.Padding = new System.Windows.Forms.Padding(3);
            this.tabCashActu.Size = new System.Drawing.Size(585, 272);
            this.tabCashActu.TabIndex = 1;
            this.tabCashActu.Text = "Cash-Flow actualisé";
            this.tabCashActu.UseVisualStyleBackColor = true;
            // 
            // tabConclusion
            // 
            this.tabConclusion.Location = new System.Drawing.Point(4, 24);
            this.tabConclusion.Name = "tabConclusion";
            this.tabConclusion.Padding = new System.Windows.Forms.Padding(3);
            this.tabConclusion.Size = new System.Drawing.Size(541, 232);
            this.tabConclusion.TabIndex = 2;
            this.tabConclusion.Text = "Conclusion";
            this.tabConclusion.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titres});
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(582, 226);
            this.dataGridView2.TabIndex = 0;
            // 
            // titres
            // 
            this.titres.HeaderText = "Column1";
            this.titres.Name = "titres";
            // 
            // Fresultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(640, 428);
            this.Controls.Add(this.tabControlCashFlow);
            this.Controls.Add(this.label1);
            this.Name = "Fresultat";
            this.Text = "Fresultat";
            this.tabControlCashFlow.ResumeLayout(false);
            this.tabCash1.ResumeLayout(false);
            this.tabCashActu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlCashFlow;
        private System.Windows.Forms.TabPage tabCash1;
        private System.Windows.Forms.TabPage tabCashActu;
        private System.Windows.Forms.TabPage tabConclusion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titres;
    }
}