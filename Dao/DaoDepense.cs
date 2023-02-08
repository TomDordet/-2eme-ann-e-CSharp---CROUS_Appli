using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;


namespace Dao {
    public class DaoDepense {
        private void Ajouter(Depense depense) {
            using(MySqlConnection cnx = dbConnexion.GetConnection()) {
                cnx.Open();
                using(MySqlCommand cmd = new MySqlCommand("insert into Depense(date, text, justificatif, montant, reparti, id_colocataire) values(@date, @texte, @justificatif, @montant, false, @id_colocataire)",cnx)) {
                    cmd.Parameters.Add(new MySqlParameter("@date",MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@text",MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@justificatif",MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@montant",MySqlDbType.Float));
                    cmd.Parameters.Add(new MySqlParameter("@id_colocataire",MySqlDbType.Int32));
                    cmd.Parameters["@date"].Value = depense.Date;
                    cmd.Parameters["@text"].Value = depense.Text;
                    cmd.Parameters["@justificatif"].Value = depense.Justificatif;
                    cmd.Parameters["@montant"].Value = depense.Montant;
                    cmd.Parameters["@id_colocataire"].Value = depense.Id_colocataire;
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public List<Depense> GetAll() {
            List<Depense> Depenses = new List<Depense>();
            using (MySqlConnection cnx = dbConnexion.GetConnection())
                {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,date,text, justificatif, montant, reparti, id_colocataire from depense;", cnx))
                    {
                    using (MySqlDataReader rdr = cmd.ExecuteReader()) 
                        {
                        while (rdr.Read()) {
                            Depenses.Add(new Depense(Convert.ToInt32(rdr["id"]),Convert.ToDateTime(rdr["date"]),Convert.ToString(rdr["text"]),Convert.ToString(rdr["justificatif"]),Convert.ToDecimal(rdr["montant"]),Convert.ToBoolean(rdr["reparti"]),Convert.ToInt32(rdr["id_colocataire"]),State.unChanged));
                        }
                    }
                }
                cnx.Close();
            }
            return Depenses;
        }
        public List<Depense> GetAll(int id) {
            List<Depense> Depenses = new List<Depense>();
            using(MySqlConnection cnx = dbConnexion.GetConnection()) {
                cnx.Open();
                using(MySqlCommand cmd = new MySqlCommand("select id,date,text, justificatif, montant, reparti, id_colocataire from depense where id_colocataire = @id;",cnx)) {
                    cmd.Parameters.Add(new MySqlParameter("@id",MySqlDbType.Int32));
                    cmd.Parameters["@id"].Value = id+1;
                    using(MySqlDataReader rdr = cmd.ExecuteReader()) {
                        while(rdr.Read()) {
                            Depenses.Add(new Depense(Convert.ToInt32(rdr["id"]),Convert.ToDateTime(rdr["date"]),Convert.ToString(rdr["text"]),Convert.ToString(rdr["justificatif"]),Convert.ToDecimal(rdr["montant"]),Convert.ToBoolean(rdr["reparti"]),Convert.ToInt32(rdr["id_colocataire"]),State.unChanged));
                        }
                    }
                }
                cnx.Close();
            }
            return Depenses;
        }
    }
}
