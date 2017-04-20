using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOO1 {
    abstract class Figura {

        private string cor;

        public string Cor { get { return this.cor; } set { this.cor = value; } }

        public Figura(string cor) {
            this.cor = cor;
        }




        public abstract double area();
    }
}
