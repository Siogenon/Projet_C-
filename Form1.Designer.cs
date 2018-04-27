namespace Genon_PROJET
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBAfficher = new System.Windows.Forms.Button();
            this.TBAjout = new System.Windows.Forms.Button();
            this.TBModifier = new System.Windows.Forms.Button();
            this.TBSupprimer = new System.Windows.Forms.Button();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.TBQuantite = new System.Windows.Forms.TextBox();
            this.TBPrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBCategorie = new System.Windows.Forms.TextBox();
            this.RBDvd = new System.Windows.Forms.RadioButton();
            this.RBBluray = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dcategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dprix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dsupport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dquantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBAfficher
            // 
            this.TBAfficher.Location = new System.Drawing.Point(48, 211);
            this.TBAfficher.Name = "TBAfficher";
            this.TBAfficher.Size = new System.Drawing.Size(75, 23);
            this.TBAfficher.TabIndex = 0;
            this.TBAfficher.Text = "Afficher";
            this.TBAfficher.UseVisualStyleBackColor = true;
            this.TBAfficher.Click += new System.EventHandler(this.TBAfficher_Click);
            // 
            // TBAjout
            // 
            this.TBAjout.Location = new System.Drawing.Point(698, 282);
            this.TBAjout.Name = "TBAjout";
            this.TBAjout.Size = new System.Drawing.Size(75, 23);
            this.TBAjout.TabIndex = 1;
            this.TBAjout.Text = "Ajouter";
            this.TBAjout.UseVisualStyleBackColor = true;
            this.TBAjout.Click += new System.EventHandler(this.TBAjout_Click);
            // 
            // TBModifier
            // 
            this.TBModifier.Location = new System.Drawing.Point(647, 233);
            this.TBModifier.Name = "TBModifier";
            this.TBModifier.Size = new System.Drawing.Size(75, 23);
            this.TBModifier.TabIndex = 2;
            this.TBModifier.Text = "Modifier";
            this.TBModifier.UseVisualStyleBackColor = true;
            this.TBModifier.Click += new System.EventHandler(this.TBModifier_Click);
            // 
            // TBSupprimer
            // 
            this.TBSupprimer.Location = new System.Drawing.Point(738, 233);
            this.TBSupprimer.Name = "TBSupprimer";
            this.TBSupprimer.Size = new System.Drawing.Size(75, 23);
            this.TBSupprimer.TabIndex = 3;
            this.TBSupprimer.Text = "Supprimer";
            this.TBSupprimer.UseVisualStyleBackColor = true;
            this.TBSupprimer.Click += new System.EventHandler(this.TBSupprimer_Click);
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(698, 12);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(100, 20);
            this.TBNom.TabIndex = 5;
            // 
            // TBQuantite
            // 
            this.TBQuantite.Location = new System.Drawing.Point(698, 176);
            this.TBQuantite.Name = "TBQuantite";
            this.TBQuantite.Size = new System.Drawing.Size(100, 20);
            this.TBQuantite.TabIndex = 6;
            // 
            // TBPrix
            // 
            this.TBPrix.Location = new System.Drawing.Point(698, 94);
            this.TBPrix.Name = "TBPrix";
            this.TBPrix.Size = new System.Drawing.Size(100, 20);
            this.TBPrix.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Categorie :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prix :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Support :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantite :";
            // 
            // TBCategorie
            // 
            this.TBCategorie.Location = new System.Drawing.Point(698, 51);
            this.TBCategorie.Name = "TBCategorie";
            this.TBCategorie.Size = new System.Drawing.Size(100, 20);
            this.TBCategorie.TabIndex = 15;
            // 
            // RBDvd
            // 
            this.RBDvd.AutoSize = true;
            this.RBDvd.Location = new System.Drawing.Point(698, 143);
            this.RBDvd.Name = "RBDvd";
            this.RBDvd.Size = new System.Drawing.Size(48, 17);
            this.RBDvd.TabIndex = 16;
            this.RBDvd.TabStop = true;
            this.RBDvd.Text = "DVD";
            this.RBDvd.UseVisualStyleBackColor = true;
            // 
            // RBBluray
            // 
            this.RBBluray.AutoSize = true;
            this.RBBluray.Location = new System.Drawing.Point(789, 143);
            this.RBBluray.Name = "RBBluray";
            this.RBBluray.Size = new System.Drawing.Size(54, 17);
            this.RBBluray.TabIndex = 17;
            this.RBBluray.TabStop = true;
            this.RBBluray.Text = "Bluray";
            this.RBBluray.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dnom,
            this.Dcategorie,
            this.Dprix,
            this.Dsupport,
            this.Dquantite});
            this.dataGridView1.Location = new System.Drawing.Point(27, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Dnom
            // 
            this.Dnom.HeaderText = "nom";
            this.Dnom.Name = "Dnom";
            // 
            // Dcategorie
            // 
            this.Dcategorie.HeaderText = "categorie";
            this.Dcategorie.Name = "Dcategorie";
            // 
            // Dprix
            // 
            this.Dprix.HeaderText = "prix";
            this.Dprix.Name = "Dprix";
            // 
            // Dsupport
            // 
            this.Dsupport.HeaderText = "support";
            this.Dsupport.Name = "Dsupport";
            // 
            // Dquantite
            // 
            this.Dquantite.HeaderText = "quantite";
            this.Dquantite.Name = "Dquantite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 312);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RBBluray);
            this.Controls.Add(this.RBDvd);
            this.Controls.Add(this.TBCategorie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPrix);
            this.Controls.Add(this.TBQuantite);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.TBSupprimer);
            this.Controls.Add(this.TBModifier);
            this.Controls.Add(this.TBAjout);
            this.Controls.Add(this.TBAfficher);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TBAfficher;
        private System.Windows.Forms.Button TBAjout;
        private System.Windows.Forms.Button TBModifier;
        private System.Windows.Forms.Button TBSupprimer;
        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.TextBox TBQuantite;
        private System.Windows.Forms.TextBox TBPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBCategorie;
        private System.Windows.Forms.RadioButton RBDvd;
        private System.Windows.Forms.RadioButton RBBluray;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dcategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dprix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dsupport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dquantite;
    }
}

