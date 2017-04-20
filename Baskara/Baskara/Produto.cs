using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskara {
    class Produto {

        public string nome { get; private set; }


        public Produto(string nome) {
            this.nome = nome;
        }

        public override string ToString() {

            return "oi";
        }
    }
}
