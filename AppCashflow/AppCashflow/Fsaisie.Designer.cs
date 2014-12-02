namespace AppCashflow
{
    partial class Fsaisie
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
            this.lbl_montant_inv_proj = new System.Windows.Forms.Label();
            this.lbl_montant_inv_mat = new System.Windows.Forms.Label();
            this.lbl_nombre_a = new System.Windows.Forms.Label();
            this.lbl_taux_actu = new System.Windows.Forms.Label();
            this.lbl_valeur_resi = new System.Windows.Forms.Label();
            this.txt_inv_proj = new System.Windows.Forms.TextBox();
            this.txt_valeur_resi = new System.Windows.Forms.TextBox();
            this.txt_taux_actu = new System.Windows.Forms.TextBox();
            this.txt_nombre_a = new System.Windows.Forms.TextBox();
            this.txt_inv_mat = new System.Windows.Forms.TextBox();
            this.lbl_e = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_valider_saisie = new System.Windows.Forms.Button();
            this.btn_annuler_saisie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.ckb_meme_valeurs = new System.Windows.Forms.CheckBox();
            this.txt_cf = new System.Windows.Forms.TextBox();
            this.txt_cv = new System.Windows.Forms.TextBox();
            this.txt_ca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_retour = new System.Windows.Forms.Button();
            this.btn_fermer_saisie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_montant_inv_proj
            // 
            this.lbl_montant_inv_proj.AutoSize = true;
            this.lbl_montant_inv_proj.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_montant_inv_proj.Location = new System.Drawing.Point(24, 136);
            this.lbl_montant_inv_proj.Name = "lbl_montant_inv_proj";
            this.lbl_montant_inv_proj.Size = new System.Drawing.Size(205, 17);
            this.lbl_montant_inv_proj.TabIndex = 0;
            this.lbl_montant_inv_proj.Text = "Montant investissement projet :";
            // 
            // lbl_montant_inv_mat
            // 
            this.lbl_montant_inv_mat.AutoSize = true;
            this.lbl_montant_inv_mat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_montant_inv_mat.Location = new System.Drawing.Point(14, 180);
            this.lbl_montant_inv_mat.Name = "lbl_montant_inv_mat";
            this.lbl_montant_inv_mat.Size = new System.Drawing.Size(220, 17);
            this.lbl_montant_inv_mat.TabIndex = 1;
            this.lbl_montant_inv_mat.Text = "Montant investissement matériel :";
            // 
            // lbl_nombre_a
            // 
            this.lbl_nombre_a.AutoSize = true;
            this.lbl_nombre_a.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_nombre_a.Location = new System.Drawing.Point(81, 220);
            this.lbl_nombre_a.Name = "lbl_nombre_a";
            this.lbl_nombre_a.Size = new System.Drawing.Size(122, 17);
            this.lbl_nombre_a.TabIndex = 2;
            this.lbl_nombre_a.Text = "Nombre d\'années :";
            // 
            // lbl_taux_actu
            // 
            this.lbl_taux_actu.AutoSize = true;
            this.lbl_taux_actu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_taux_actu.Location = new System.Drawing.Point(70, 261);
            this.lbl_taux_actu.Name = "lbl_taux_actu";
            this.lbl_taux_actu.Size = new System.Drawing.Size(139, 17);
            this.lbl_taux_actu.TabIndex = 3;
            this.lbl_taux_actu.Text = "Taux d\'actualisation :";
            // 
            // lbl_valeur_resi
            // 
            this.lbl_valeur_resi.AutoSize = true;
            this.lbl_valeur_resi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_valeur_resi.Location = new System.Drawing.Point(87, 306);
            this.lbl_valeur_resi.Name = "lbl_valeur_resi";
            this.lbl_valeur_resi.Size = new System.Drawing.Size(121, 17);
            this.lbl_valeur_resi.TabIndex = 5;
            this.lbl_valeur_resi.Text = "Valeur résiduelle :";
            // 
            // txt_inv_proj
            // 
            this.txt_inv_proj.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_inv_proj.Location = new System.Drawing.Point(233, 130);
            this.txt_inv_proj.Name = "txt_inv_proj";
            this.txt_inv_proj.Size = new System.Drawing.Size(100, 23);
            this.txt_inv_proj.TabIndex = 6;
            this.txt_inv_proj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inv_proj_KeyPress);
            // 
            // txt_valeur_resi
            // 
            this.txt_valeur_resi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_valeur_resi.Location = new System.Drawing.Point(233, 306);
            this.txt_valeur_resi.Name = "txt_valeur_resi";
            this.txt_valeur_resi.Size = new System.Drawing.Size(100, 23);
            this.txt_valeur_resi.TabIndex = 7;
            this.txt_valeur_resi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valeur_resi_KeyPress);
            // 
            // txt_taux_actu
            // 
            this.txt_taux_actu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_taux_actu.Location = new System.Drawing.Point(233, 261);
            this.txt_taux_actu.Name = "txt_taux_actu";
            this.txt_taux_actu.Size = new System.Drawing.Size(100, 23);
            this.txt_taux_actu.TabIndex = 8;
            this.txt_taux_actu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_taux_actu_KeyPress);
            // 
            // txt_nombre_a
            // 
            this.txt_nombre_a.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_nombre_a.Location = new System.Drawing.Point(233, 220);
            this.txt_nombre_a.Name = "txt_nombre_a";
            this.txt_nombre_a.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre_a.TabIndex = 9;
            this.txt_nombre_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_a_KeyPress);
            // 
            // txt_inv_mat
            // 
            this.txt_inv_mat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txt_inv_mat.Location = new System.Drawing.Point(233, 177);
            this.txt_inv_mat.Name = "txt_inv_mat";
            this.txt_inv_mat.Size = new System.Drawing.Size(100, 23);
            this.txt_inv_mat.TabIndex = 10;
            this.txt_inv_mat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inv_mat_KeyPress);
            // 
            // lbl_e
            // 
            this.lbl_e.AutoSize = true;
            this.lbl_e.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_e.Location = new System.Drawing.Point(342, 136);
            this.lbl_e.Name = "lbl_e";
            this.lbl_e.Size = new System.Drawing.Size(15, 17);
            this.lbl_e.TabIndex = 11;
            this.lbl_e.Text = "€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(342, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(342, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(342, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "an(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(339, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "%";
            // 
            // btn_valider_saisie
            // 
            this.btn_valider_saisie.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btn_valider_saisie.Location = new System.Drawing.Point(134, 398);
            this.btn_valider_saisie.Name = "btn_valider_saisie";
            this.btn_valider_saisie.Size = new System.Drawing.Size(75, 23);
            this.btn_valider_saisie.TabIndex = 16;
            this.btn_valider_saisie.Text = "Valider";
            this.btn_valider_saisie.UseVisualStyleBackColor = true;
            this.btn_valider_saisie.Click += new System.EventHandler(this.btn_valider_saisie_Click);
            // 
            // btn_annuler_saisie
            // 
            this.btn_annuler_saisie.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler_saisie.Location = new System.Drawing.Point(258, 398);
            this.btn_annuler_saisie.Name = "btn_annuler_saisie";
            this.btn_annuler_saisie.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler_saisie.TabIndex = 17;
            this.btn_annuler_saisie.Text = "Annuler";
            this.btn_annuler_saisie.UseVisualStyleBackColor = true;
            this.btn_annuler_saisie.Click += new System.EventHandler(this.btn_annuler_saisie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_suivant);
            this.groupBox1.Controls.Add(this.ckb_meme_valeurs);
            this.groupBox1.Controls.Add(this.txt_cf);
            this.groupBox1.Controls.Add(this.txt_cv);
            this.groupBox1.Controls.Add(this.txt_ca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(407, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 227);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information pour l\'année n°";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_suivant
            // 
            this.btn_suivant.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suivant.Location = new System.Drawing.Point(137, 180);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(75, 23);
            this.btn_suivant.TabIndex = 7;
            this.btn_suivant.Text = "Suivant";
            this.btn_suivant.UseVisualStyleBackColor = true;
            // 
            // ckb_meme_valeurs
            // 
            this.ckb_meme_valeurs.AutoSize = true;
            this.ckb_meme_valeurs.Location = new System.Drawing.Point(55, 155);
            this.ckb_meme_valeurs.Name = "ckb_meme_valeurs";
            this.ckb_meme_valeurs.Size = new System.Drawing.Size(250, 19);
            this.ckb_meme_valeurs.TabIndex = 6;
            this.ckb_meme_valeurs.Text = "Mêmes valeurs pour les années suivantes";
            this.ckb_meme_valeurs.UseVisualStyleBackColor = true;
            // 
            // txt_cf
            // 
            this.txt_cf.Location = new System.Drawing.Point(175, 111);
            this.txt_cf.Name = "txt_cf";
            this.txt_cf.Size = new System.Drawing.Size(100, 22);
            this.txt_cf.TabIndex = 5;
            this.txt_cf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cf_KeyPress);
            // 
            // txt_cv
            // 
            this.txt_cv.Location = new System.Drawing.Point(175, 77);
            this.txt_cv.Name = "txt_cv";
            this.txt_cv.Size = new System.Drawing.Size(100, 22);
            this.txt_cv.TabIndex = 4;
            this.txt_cv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cv_KeyPress);
            // 
            // txt_ca
            // 
            this.txt_ca.Location = new System.Drawing.Point(175, 42);
            this.txt_ca.Name = "txt_ca";
            this.txt_ca.Size = new System.Drawing.Size(100, 22);
            this.txt_ca.TabIndex = 3;
            this.txt_ca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ca_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Charges Fixes :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Charges variables :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chiffre d\'affaires :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(283, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Saisie des données du projet :";
            // 
            // btn_retour
            // 
            this.btn_retour.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.Location = new System.Drawing.Point(194, 439);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 20;
            this.btn_retour.Text = "Retour arrière";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // btn_fermer_saisie
            // 
            this.btn_fermer_saisie.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermer_saisie.Location = new System.Drawing.Point(635, 439);
            this.btn_fermer_saisie.Name = "btn_fermer_saisie";
            this.btn_fermer_saisie.Size = new System.Drawing.Size(77, 37);
            this.btn_fermer_saisie.TabIndex = 21;
            this.btn_fermer_saisie.Text = "Fermer";
            this.btn_fermer_saisie.UseVisualStyleBackColor = true;
            this.btn_fermer_saisie.Click += new System.EventHandler(this.btn_fermer_saisie_Click);
            // 
            // Fsaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(766, 488);
            this.Controls.Add(this.btn_fermer_saisie);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_annuler_saisie);
            this.Controls.Add(this.btn_valider_saisie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_e);
            this.Controls.Add(this.txt_inv_mat);
            this.Controls.Add(this.txt_nombre_a);
            this.Controls.Add(this.txt_taux_actu);
            this.Controls.Add(this.txt_valeur_resi);
            this.Controls.Add(this.txt_inv_proj);
            this.Controls.Add(this.lbl_valeur_resi);
            this.Controls.Add(this.lbl_taux_actu);
            this.Controls.Add(this.lbl_nombre_a);
            this.Controls.Add(this.lbl_montant_inv_mat);
            this.Controls.Add(this.lbl_montant_inv_proj);
            this.Name = "Fsaisie";
            this.Text = "Fsaisie";
            this.Load += new System.EventHandler(this.Fsaisie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_montant_inv_proj;
        private System.Windows.Forms.Label lbl_montant_inv_mat;
        private System.Windows.Forms.Label lbl_nombre_a;
        private System.Windows.Forms.Label lbl_taux_actu;
        private System.Windows.Forms.Label lbl_valeur_resi;
        private System.Windows.Forms.TextBox txt_inv_proj;
        private System.Windows.Forms.TextBox txt_valeur_resi;
        private System.Windows.Forms.TextBox txt_taux_actu;
        private System.Windows.Forms.TextBox txt_nombre_a;
        private System.Windows.Forms.TextBox txt_inv_mat;
        private System.Windows.Forms.Label lbl_e;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_valider_saisie;
        private System.Windows.Forms.Button btn_annuler_saisie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.CheckBox ckb_meme_valeurs;
        private System.Windows.Forms.TextBox txt_cf;
        private System.Windows.Forms.TextBox txt_cv;
        private System.Windows.Forms.TextBox txt_ca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Button btn_fermer_saisie;
    }
}