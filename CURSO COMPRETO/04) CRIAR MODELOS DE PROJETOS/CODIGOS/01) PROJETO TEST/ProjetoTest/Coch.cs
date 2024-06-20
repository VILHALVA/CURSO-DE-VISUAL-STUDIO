using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest
{
    internal class Coch
    { 
        public string marca { get; set; }
        public string modelo { get; set; }
        public string matricula {  get; set; }

        public Coch (string marca, string modelo, string matricula)
        {
            this.marca = marca;
            this.modelo = modelo;   
            this.matricula = matricula;
        }
    }
}
