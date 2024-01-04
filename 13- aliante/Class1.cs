using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13__aliante
{
    interface Componente
    {
        void add();
        void remove();
        void Getchild();
    }

    class Aliante : Componente
    {
        private string _ala;
        private string _fusoliera;
        private string _coda;
        public Aliante(string ala, string fusoliera, string coda)
        {
            this._ala = ala;
            this._fusoliera = fusoliera;
            this._coda = coda;
        }

        public virtual void descrizione(string descrizione)
        {
            Console.WriteLine(descrizione);
        }

        public void add()
        {
            
        }

        public void Getchild()
        {
            
        }

        public void remove()
        {
            
        }
    }

    class Ala :  Componente 
    {
        private double _lunghezza;
        private double _apertura;
        private double _costo;

        public Ala(double lunghezza, double apertura, double costo)
        {
            this._lunghezza = lunghezza;
            this._apertura = apertura;
            this._costo = costo;
        }
        public virtual void descrizione(string descrizione)
        {
            Console.WriteLine(descrizione);
        }
        public virtual void prezzo(double prezzo)
        {
            Console.WriteLine(prezzo);
        }


        public void add()
        {

        }

        public void Getchild()
        {

        }

        public void remove()
        {

        }
    }
    class Fusioliera : Componente
    {
        public void add()
        {

        }

        public void Getchild()
        {

        }

        public void remove()
        {

        }
    }
    class Coda : Componente
    {
        public void add()
        {

        }

        public void Getchild()
        {

        }

        public void remove()
        {

        }
    }
    class Ruota : Componente
    {
        public void add()
        {

        }

        public void Getchild()
        {

        }

        public void remove()
        {

        }
    }

}
