namespace Gestion_d_ecole
{
    partial class FormNotes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnvalider = new System.Windows.Forms.Button();
            this.txtclasse = new System.Windows.Forms.ComboBox();
            this.txtmatiere = new System.Windows.Forms.ComboBox();
            this.txtetudiant = new System.Windows.Forms.TextBox();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.btnvoirmatiere = new System.Windows.Forms.Button();
            this.btnajouternote = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(578, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matiere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Etudiant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Note";
            // 
            // btnvalider
            // 
            this.btnvalider.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalider.Location = new System.Drawing.Point(172, 450);
            this.btnvalider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(224, 54);
            this.btnvalider.TabIndex = 6;
            this.btnvalider.Text = "VALIDER";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // txtclasse
            // 
            this.txtclasse.FormattingEnabled = true;
            this.txtclasse.Location = new System.Drawing.Point(197, 84);
            this.txtclasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtclasse.Name = "txtclasse";
            this.txtclasse.Size = new System.Drawing.Size(136, 28);
            this.txtclasse.TabIndex = 7;
            this.txtclasse.SelectedIndexChanged += new System.EventHandler(this.txtclasse_SelectedIndexChanged);
            this.txtclasse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclasse_KeyPress);
            // 
            // txtmatiere
            // 
            this.txtmatiere.FormattingEnabled = true;
            this.txtmatiere.Location = new System.Drawing.Point(197, 198);
            this.txtmatiere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmatiere.Name = "txtmatiere";
            this.txtmatiere.Size = new System.Drawing.Size(136, 28);
            this.txtmatiere.TabIndex = 9;
            this.txtmatiere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatiere_KeyPress);
            // 
            // txtetudiant
            // 
            this.txtetudiant.Location = new System.Drawing.Point(197, 310);
            this.txtetudiant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtetudiant.Name = "txtetudiant";
            this.txtetudiant.ReadOnly = true;
            this.txtetudiant.Size = new System.Drawing.Size(210, 26);
            this.txtetudiant.TabIndex = 10;
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(197, 369);
            this.txtnote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnote.Multiline = true;
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(210, 45);
            this.txtnote.TabIndex = 11;
            // 
            // btnvoirmatiere
            // 
            this.btnvoirmatiere.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoirmatiere.Location = new System.Drawing.Point(362, 84);
            this.btnvoirmatiere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnvoirmatiere.Name = "btnvoirmatiere";
            this.btnvoirmatiere.Size = new System.Drawing.Size(196, 44);
            this.btnvoirmatiere.TabIndex = 13;
            this.btnvoirmatiere.Text = "Voir les matieres";
            this.btnvoirmatiere.UseVisualStyleBackColor = true;
            this.btnvoirmatiere.Click += new System.EventHandler(this.btnvoirmatiere_Click);
            // 
            // btnajouternote
            // 
            this.btnajouternote.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouternote.Location = new System.Drawing.Point(376, 184);
            this.btnajouternote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnajouternote.Name = "btnajouternote";
            this.btnajouternote.Size = new System.Drawing.Size(162, 44);
            this.btnajouternote.TabIndex = 14;
            this.btnajouternote.Text = "Ajouter note";
            this.btnajouternote.UseVisualStyleBackColor = true;
            this.btnajouternote.Click += new System.EventHandler(this.btnajouternote_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnajouternote);
            this.Controls.Add(this.btnvoirmatiere);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.txtetudiant);
            this.Controls.Add(this.txtmatiere);
            this.Controls.Add(this.txtclasse);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voir Les Cours";
            this.Load += new System.EventHandler(this.FormNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.ComboBox txtclasse;
        private System.Windows.Forms.ComboBox txtmatiere;
        private System.Windows.Forms.TextBox txtetudiant;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Button btnvoirmatiere;
        private System.Windows.Forms.Button btnajouternote;
        private System.Windows.Forms.Button button1;
    }
}