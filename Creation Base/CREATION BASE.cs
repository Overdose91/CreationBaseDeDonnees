using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CREATION_BASE
{
    public struct Fiche_Connex
    {
        public string nomServ {get; set;}
        public string nomBase { get; set; }
        public string identifiant { get; set; }
        public string password { get; set; }
    }
    class Creation_Base
    {
        private Fiche_Connex idCn1 = new Fiche_Connex();
        private Fiche_Connex idCn2 = new Fiche_Connex();
        private SqlConnection cn = new SqlConnection();
        public string script { get; set; }

        public Creation_Base(Fiche_Connex idConnex1, Fiche_Connex idConnex2 )
        {
            this.idCn1 = idConnex1;
            this.idCn2 = idConnex2;
            this.cn = new SqlConnection(@"Data Source=" + idCn1.nomServ + ";Initial Catalog=" + idCn1.nomBase + ";User Id=" + idCn1.identifiant + ";Password=" + idCn1.password);
        }

        //METHODE RECUPERE TOUS LES NOM DE BASES
        public bool recup_Database()
        {
            try
            {
                SqlCommand requete = new SqlCommand("SELECT name FROM sys.databases WHERE database_id > 4", cn);
                cn.Open();
                SqlDataReader read = requete.ExecuteReader();
                while (read.Read())
                {
                    if (this.idCn2.nomBase.Equals(read["name"].ToString(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        cn.Close();
                        return false;
                    }
                }
                read.Close();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //METHODE RECUPERE TOUS LES UTILISATEURS
        public bool recup_Utilisateur()
        {
            try
            {
                SqlCommand requete = new SqlCommand("SELECT name FROM Sys.sql_logins", cn);
                SqlDataReader read = requete.ExecuteReader();
                while (read.Read())
                {
                    if (idCn2.identifiant.Equals(read["name"].ToString(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        cn.Close();
                        return false;
                    }
                }
                read.Close();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //METHODE CREATION BDD
        public bool req_Create_Bdd()
        {
            try
            {
                SqlCommand requete = new SqlCommand(@"USE master;  CREATE DATABASE " + idCn2.nomBase + ";", cn);
                requete.ExecuteNonQuery();

                MessageBox.Show("La base a bien été créee !", "Base créee...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //METHODE CREATION DU USER
        public bool req_Create_User()
        {
            try
            {
                string createUSER = @"USE " + idCn2.nomBase + ";";
                createUSER += @"CREATE LOGIN " + idCn2.identifiant + " WITH PASSWORD = '" + idCn2.password + "', DEFAULT_DATABASE =" + idCn2.nomBase + @", CHECK_POLICY = OFF, CHECK_EXPIRATION=OFF;";
                createUSER += @"CREATE USER [" + idCn2.identifiant + "] FOR LOGIN [" + idCn2.identifiant + "];";
                createUSER += @"EXEC sp_addrolemember N'db_owner ', N'" + idCn2.identifiant + "';";

                SqlCommand requete2 = new SqlCommand(createUSER, cn);
                requete2.ExecuteNonQuery();

                MessageBox.Show("L'utilisateur a bien été ajouté !", "Utiliasteur crée...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        //METHODE EXECUTE LE SCRIPT SQL
        public bool req_Script_Ppme()
        {
            try
            {   //**ATTENTION**
                //Votre script de doit pas comporter la commande GO (non prise en charge)
                string createUSER = @"USE " + idCn2.nomBase + ";";
                //Les scripts à mettre dans le dossier "script" fournit par cette solution
                string scriptReq = File.ReadAllText(@"Script\" + script);               
                SqlCommand requete = new SqlCommand(createUSER + scriptReq, cn);
                requete.ExecuteNonQuery();

                //Vos triggers doivent être exécuté indépendamment de votre script de création de tables
                string trigger = File.ReadAllText(@"Script\Trigger_Script_SQL.sql");
                SqlCommand requete2 = new SqlCommand(trigger, cn);
                requete2.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Les scripts ont bien été ajouté !", "Script ajoutée...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
