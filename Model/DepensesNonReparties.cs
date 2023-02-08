using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    class DepensesNonReparties {

        List<Depense> lesDepenses = new List<Depense>();

        public DepensesNonReparties(List<Depense> lesDepenses) {
            this.lesDepenses = lesDepenses;
        }
    }
}
