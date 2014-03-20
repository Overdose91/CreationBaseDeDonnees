namespace CreationBaseDeDonnees
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTestConnex = new System.Windows.Forms.Button();
            this.groupBoxTextConnex = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelServer = new System.Windows.Forms.Label();
            this.textBoxPwdConnex = new System.Windows.Forms.TextBox();
            this.textBoxUserConnex = new System.Windows.Forms.TextBox();
            this.textBoxServerConnex = new System.Windows.Forms.TextBox();
            this.groupBoxCreateBdd = new System.Windows.Forms.GroupBox();
            this.comboBoxScript = new System.Windows.Forms.ComboBox();
            this.labelScript = new System.Windows.Forms.Label();
            this.buttonCreateBdd = new System.Windows.Forms.Button();
            this.textBoxCreatePwd = new System.Windows.Forms.TextBox();
            this.labelPWD = new System.Windows.Forms.Label();
            this.textBoxCreateUser = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.textBoxCreateBdd = new System.Windows.Forms.TextBox();
            this.labelNameBDD = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTextConnex.SuspendLayout();
            this.groupBoxCreateBdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Création Base de données SQL ";
            // 
            // buttonTestConnex
            // 
            this.buttonTestConnex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestConnex.Location = new System.Drawing.Point(9, 111);
            this.buttonTestConnex.Name = "buttonTestConnex";
            this.buttonTestConnex.Size = new System.Drawing.Size(217, 29);
            this.buttonTestConnex.TabIndex = 3;
            this.buttonTestConnex.Text = "Test connexion";
            this.buttonTestConnex.UseVisualStyleBackColor = true;
            this.buttonTestConnex.Click += new System.EventHandler(this.buttonTestConnex_Click);
            // 
            // groupBoxTextConnex
            // 
            this.groupBoxTextConnex.Controls.Add(this.label4);
            this.groupBoxTextConnex.Controls.Add(this.label3);
            this.groupBoxTextConnex.Controls.Add(this.buttonTestConnex);
            this.groupBoxTextConnex.Controls.Add(this.labelServer);
            this.groupBoxTextConnex.Controls.Add(this.textBoxPwdConnex);
            this.groupBoxTextConnex.Controls.Add(this.textBoxUserConnex);
            this.groupBoxTextConnex.Controls.Add(this.textBoxServerConnex);
            this.groupBoxTextConnex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTextConnex.Location = new System.Drawing.Point(22, 56);
            this.groupBoxTextConnex.Name = "groupBoxTextConnex";
            this.groupBoxTextConnex.Size = new System.Drawing.Size(237, 146);
            this.groupBoxTextConnex.TabIndex = 4;
            this.groupBoxTextConnex.TabStop = false;
            this.groupBoxTextConnex.Text = "Sur quel SQL Server ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Utilisateur : ";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServer.Location = new System.Drawing.Point(6, 26);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(53, 13);
            this.labelServer.TabIndex = 3;
            this.labelServer.Text = "Serveur : ";
            // 
            // textBoxPwdConnex
            // 
            this.textBoxPwdConnex.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPwdConnex.Location = new System.Drawing.Point(85, 75);
            this.textBoxPwdConnex.Name = "textBoxPwdConnex";
            this.textBoxPwdConnex.PasswordChar = '*';
            this.textBoxPwdConnex.Size = new System.Drawing.Size(141, 20);
            this.textBoxPwdConnex.TabIndex = 2;
            this.textBoxPwdConnex.Text = "0";
            // 
            // textBoxUserConnex
            // 
            this.textBoxUserConnex.Location = new System.Drawing.Point(85, 49);
            this.textBoxUserConnex.Name = "textBoxUserConnex";
            this.textBoxUserConnex.Size = new System.Drawing.Size(141, 20);
            this.textBoxUserConnex.TabIndex = 1;
            this.textBoxUserConnex.Text = "sa";
            // 
            // textBoxServerConnex
            // 
            this.textBoxServerConnex.Location = new System.Drawing.Point(85, 23);
            this.textBoxServerConnex.Name = "textBoxServerConnex";
            this.textBoxServerConnex.Size = new System.Drawing.Size(141, 20);
            this.textBoxServerConnex.TabIndex = 0;
            this.textBoxServerConnex.Text = "localhost\\sqlexpress";
            // 
            // groupBoxCreateBdd
            // 
            this.groupBoxCreateBdd.Controls.Add(this.comboBoxScript);
            this.groupBoxCreateBdd.Controls.Add(this.labelScript);
            this.groupBoxCreateBdd.Controls.Add(this.buttonCreateBdd);
            this.groupBoxCreateBdd.Controls.Add(this.textBoxCreatePwd);
            this.groupBoxCreateBdd.Controls.Add(this.labelPWD);
            this.groupBoxCreateBdd.Controls.Add(this.textBoxCreateUser);
            this.groupBoxCreateBdd.Controls.Add(this.Login);
            this.groupBoxCreateBdd.Controls.Add(this.textBoxCreateBdd);
            this.groupBoxCreateBdd.Controls.Add(this.labelNameBDD);
            this.groupBoxCreateBdd.Location = new System.Drawing.Point(22, 218);
            this.groupBoxCreateBdd.Name = "groupBoxCreateBdd";
            this.groupBoxCreateBdd.Size = new System.Drawing.Size(237, 181);
            this.groupBoxCreateBdd.TabIndex = 5;
            this.groupBoxCreateBdd.TabStop = false;
            this.groupBoxCreateBdd.Text = "Création de votre base";
            this.groupBoxCreateBdd.Visible = false;
            // 
            // comboBoxScript
            // 
            this.comboBoxScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScript.FormattingEnabled = true;
            this.comboBoxScript.Location = new System.Drawing.Point(108, 104);
            this.comboBoxScript.Name = "comboBoxScript";
            this.comboBoxScript.Size = new System.Drawing.Size(118, 21);
            this.comboBoxScript.TabIndex = 8;
            this.comboBoxScript.SelectedIndexChanged += new System.EventHandler(this.comboBoxScript_SelectedIndexChanged);
            // 
            // labelScript
            // 
            this.labelScript.AutoSize = true;
            this.labelScript.Location = new System.Drawing.Point(6, 107);
            this.labelScript.Name = "labelScript";
            this.labelScript.Size = new System.Drawing.Size(83, 13);
            this.labelScript.TabIndex = 7;
            this.labelScript.Text = "Langage script :";
            // 
            // buttonCreateBdd
            // 
            this.buttonCreateBdd.Enabled = false;
            this.buttonCreateBdd.Location = new System.Drawing.Point(9, 140);
            this.buttonCreateBdd.Name = "buttonCreateBdd";
            this.buttonCreateBdd.Size = new System.Drawing.Size(217, 30);
            this.buttonCreateBdd.TabIndex = 6;
            this.buttonCreateBdd.Text = "Créer la base";
            this.buttonCreateBdd.UseVisualStyleBackColor = true;
            this.buttonCreateBdd.Click += new System.EventHandler(this.buttonCreateBdd_Click);
            // 
            // textBoxCreatePwd
            // 
            this.textBoxCreatePwd.Location = new System.Drawing.Point(108, 76);
            this.textBoxCreatePwd.Name = "textBoxCreatePwd";
            this.textBoxCreatePwd.Size = new System.Drawing.Size(118, 20);
            this.textBoxCreatePwd.TabIndex = 5;
            // 
            // labelPWD
            // 
            this.labelPWD.AutoSize = true;
            this.labelPWD.Location = new System.Drawing.Point(6, 79);
            this.labelPWD.Name = "labelPWD";
            this.labelPWD.Size = new System.Drawing.Size(77, 13);
            this.labelPWD.TabIndex = 4;
            this.labelPWD.Text = "Mot de passe :";
            // 
            // textBoxCreateUser
            // 
            this.textBoxCreateUser.Location = new System.Drawing.Point(108, 49);
            this.textBoxCreateUser.Name = "textBoxCreateUser";
            this.textBoxCreateUser.Size = new System.Drawing.Size(118, 20);
            this.textBoxCreateUser.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxCreateUser, "Laissez ce champ vide si vous ne voulez pas créer d\'utilisateur (L\'utilisateur pa" +
                    "r défaut sera le \'sa\').");
            this.textBoxCreateUser.TextChanged += new System.EventHandler(this.textBoxCreateUser_TextChanged);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(6, 52);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(59, 13);
            this.Login.TabIndex = 2;
            this.Login.Text = "Utilisateur :";
            // 
            // textBoxCreateBdd
            // 
            this.textBoxCreateBdd.Location = new System.Drawing.Point(108, 24);
            this.textBoxCreateBdd.Name = "textBoxCreateBdd";
            this.textBoxCreateBdd.Size = new System.Drawing.Size(118, 20);
            this.textBoxCreateBdd.TabIndex = 1;
            this.textBoxCreateBdd.TextChanged += new System.EventHandler(this.textBoxCreateBdd_TextChanged);
            // 
            // labelNameBDD
            // 
            this.labelNameBDD.AutoSize = true;
            this.labelNameBDD.Location = new System.Drawing.Point(6, 27);
            this.labelNameBDD.Name = "labelNameBDD";
            this.labelNameBDD.Size = new System.Drawing.Size(96, 13);
            this.labelNameBDD.TabIndex = 0;
            this.labelNameBDD.Text = "Base de données :";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Petite précision";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonTestConnex;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(279, 414);
            this.Controls.Add(this.groupBoxCreateBdd);
            this.Controls.Add(this.groupBoxTextConnex);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'une base SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTextConnex.ResumeLayout(false);
            this.groupBoxTextConnex.PerformLayout();
            this.groupBoxCreateBdd.ResumeLayout(false);
            this.groupBoxCreateBdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTestConnex;
        private System.Windows.Forms.GroupBox groupBoxTextConnex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox textBoxPwdConnex;
        private System.Windows.Forms.TextBox textBoxUserConnex;
        private System.Windows.Forms.TextBox textBoxServerConnex;
        private System.Windows.Forms.GroupBox groupBoxCreateBdd;
        private System.Windows.Forms.TextBox textBoxCreateBdd;
        private System.Windows.Forms.Label labelNameBDD;
        private System.Windows.Forms.TextBox textBoxCreatePwd;
        private System.Windows.Forms.Label labelPWD;
        private System.Windows.Forms.TextBox textBoxCreateUser;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button buttonCreateBdd;
        private System.Windows.Forms.ComboBox comboBoxScript;
        private System.Windows.Forms.Label labelScript;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

