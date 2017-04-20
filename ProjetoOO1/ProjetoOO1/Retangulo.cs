using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOO1 {
    class Retangulo : Figura {

        private double largura;
        public double altura { get; set; }


        public double Largura { get { return this.largura; } set { this.largura = value; } }

        public Retangulo(double a, double b, string cor) : base(cor) {
            this.largura = a;
            this.altura = b;
        }

        public override double area() {
            return largura * altura;
        }
    }
}
