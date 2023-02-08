using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class Colocataire {
        int id;
        string nom;
        string prenom;
        string mail;
        string telephone;

        public Colocataire(int id,string nom,string prenom,string mail,string telephone) {
            this.id=id;
            this.nom=nom;
            this.prenom=prenom;
            this.mail=mail;
            this.telephone=telephone;
        }
        public int Id {
            get { return id; }
            set { id=value; }
        }
        public string Nom {
            get { return nom; }
            set { nom=value; }
        }
        public string Prenom {
            get { return prenom; }
            set { prenom=value; }
        }
        public string Mail {
            get { return mail; }
            set { mail=value; }
        }
        public string Telephone {
            get { return telephone; }
            set { telephone=value; }
        }
    }
}