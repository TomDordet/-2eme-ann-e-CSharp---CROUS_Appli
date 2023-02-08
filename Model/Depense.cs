using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Depense
    {
        protected int id;
        protected DateTime date;
        protected string text;
        protected string justificatif;
        protected decimal montant;
        protected bool reparti;
        protected int id_colocataire;
        protected State state;

        public Depense(int id, DateTime date, string text, string justificatif, decimal montant, bool reparti, int id_colocataire, State state)
        {
            this.id = id;
            this.date = date;
            this.text = text;
            this.justificatif = justificatif;
            this.montant = montant;
            this.reparti = reparti;
            this.id_colocataire = id_colocataire;
            this.state = state;
        }
        public int Id 
        {
            get { return id; }
            set { id=value; }
        }
        public DateTime Date 
        {
            get { return date; }
            set { date=value; }
        }
        public string Text {
            get { return text; }
            set { text=value; }
        }
        public string Justificatif {
            get { return justificatif; }
            set { justificatif=value; }
        }
        public decimal Montant {
            get { return montant; }
            set { montant=value; }
        }
        public bool Reparti{
            get { return reparti; }
            set { reparti=value; }
        }
        public int Id_colocataire {
            get { return id_colocataire; }
            set { id_colocataire=value; }
        }

        public override string ToString() {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}", this.id,this.date,this.text,this.justificatif,this.montant,this.reparti,this.id_colocataire);
        }





    }
}
