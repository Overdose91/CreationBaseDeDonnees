using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using CREATION_BASE;

namespace CreationBaseDeDonnees
{
    public partial class Form1 : Form
    {
        string scriptTemp = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(279, 216);
        }

        private void buttonTestConnex_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;       

            if (try_connexion())
            {
                //initialisation de la fenêtre
                this.AcceptButton = this.buttonCreateBdd;
                this.ClientSize = new System.Drawing.Size(278, 420);
                this.textBoxPwdConnex.Enabled = false;
                this.textBoxServerConnex.Enabled = false;
                this.textBoxUserConnex.Enabled = false;
                this.groupBoxCreateBdd.Visible = true;
                this.buttonTestConnex.Enabled = false;
                //Récupération des scripts
                if (!recup_script())
                {
                    MessageBox.Show("Je n'ai pas pu charger les scripts. \n L'application se fermera automatiquement, veuillez vérifier que vos scripts soient bien dans le dossier \"Script\" et relancer l'application.", "Erreur chargement des scripts...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                comboBoxScript.SelectedIndex = 0;
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void buttonCreateBdd_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Vous êtes sur le point de créer la base : " + textBoxCreateBdd.Text + "\nEtes vous sûr de vouloir continuer ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
            #region Initialisation de la fiche de connexion (classe struct) + création de l'objet CreationBaseX
            //Initialisation de la connexion au sqserver
            Fiche_Connex ficheCn1 = new Fiche_Connex();
            ficheCn1.nomServ = textBoxServerConnex.Text;
            ficheCn1.nomBase = "master";
            ficheCn1.identifiant = textBoxUserConnex.Text;
            ficheCn1.password = textBoxPwdConnex.Text;
            //Initialisation pour la création de la nouvelle base
            Fiche_Connex ficheCn2 = new Fiche_Connex();
            ficheCn2.nomServ = textBoxServerConnex.Text;
            ficheCn2.nomBase = textBoxCreateBdd.Text;
            ficheCn2.identifiant = textBoxCreateUser.Text;
            ficheCn2.password = textBoxCreatePwd.Text;

            Creation_Base newBase = new Creation_Base(ficheCn1, ficheCn2);
            newBase.script = scriptTemp;
            #endregion
            
                this.Cursor = System.Windows.Forms.Cursors.AppStarting;
                if (!String.IsNullOrWhiteSpace(textBoxCreateBdd.Text))
                {
                    #region Création avec user
                    if (!String.IsNullOrWhiteSpace(textBoxCreateUser.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(textBoxCreatePwd.Text))
                        {
                            if (newBase.recup_Database())
                            {
                                if (newBase.recup_Utilisateur())
                                {
                                    if (newBase.req_Create_Bdd())
                                        if (newBase.req_Create_User())
                                            if (newBase.req_Script_Ppme())
                                            {
                                                MessageBox.Show("Création de la base terminée", "Création terminée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                }
                                else
                                    MessageBox.Show("Le nom d'utilisateur est déjà existant, veuillez choisir un autre nom d'utilisateur.", "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("La base est déjà existante, veuillez choisir un autre nom de base.", "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Le champ password est vide...\nVeuillez saisir un mot de passe.", "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                    #endregion
                    #region Création sans user
                    else
                    {
                        if (newBase.recup_Database())
                        {
                            if (newBase.req_Create_Bdd())
                                if (newBase.req_Script_Ppme())
                                {
                                    MessageBox.Show("Création de la base terminée", "Création terminée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                        }
                        else
                            MessageBox.Show("La base est déjà existante, veuillez choisir un autre nom de base.", "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                    #endregion
                }
                else
                    MessageBox.Show("Nom de la base de données incorrecte...", "Base de données incorrecte...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Cursor = System.Windows.Forms.Cursors.Default; 
            }
        }

        //METHODE TEST CONNEXION
        public bool try_connexion()
        {
            SqlConnection maConnexion = new SqlConnection(@"Data Source=" + textBoxServerConnex.Text + ";Initial Catalog=master;User Id=" + textBoxUserConnex.Text + ";Password=" + textBoxPwdConnex.Text);
            try
            {
                maConnexion.Open();
                maConnexion.Close();
                MessageBox.Show("Connexion réussie...", "Connecté", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur connexion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }        
        //AJOUTE LE NOM DES SCRIPTS DANS LA COMBO
        private bool recup_script()
        {
            try
            {
                //Récupère tous les fichier commençant par "Script_SQL_" et les mes dans la combo
                DirectoryInfo script = new DirectoryInfo("Script");
                FileInfo[] fichier = script.GetFiles("Script_SQL_*", SearchOption.TopDirectoryOnly);
                IEnumerator listFichier = fichier.GetEnumerator();
                while (listFichier.MoveNext())
                {
                    comboBoxScript.Items.Add(listFichier.Current.ToString());
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void comboBoxScript_SelectedIndexChanged(object sender, EventArgs e)
        {
            scriptTemp = comboBoxScript.Text;
        }

        private void textBoxCreateUser_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxCreateUser.Text))
            {
                textBoxCreatePwd.Enabled = true;
            }
            else
            {
                textBoxCreatePwd.Enabled = false;
            }
        }

        private void textBoxCreateBdd_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxCreateBdd.Text))
            {
                this.buttonCreateBdd.Enabled = true;
            }
            else
            {
                this.buttonCreateBdd.Enabled = false;
            }
        }
    }
}
