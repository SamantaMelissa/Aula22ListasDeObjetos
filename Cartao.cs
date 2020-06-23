using System;

namespace Aula22ListaDeObjetos
{
    public class Cartao
    {

        public string Titular { get; set; }

        public int numero { get; set; }

        public string bandeira { get; set; }

        public DateTime vencimento {get; set;}

        public int cvv { get; set; }

        public Cartao(){

        }
        
        public Cartao( string _titular, int _numero, string _bandeira, int _cvv){

            this.Titular = _titular;
            this.numero = _numero;
            this.bandeira = _bandeira;
            this.cvv = _cvv;


        }
    }
}