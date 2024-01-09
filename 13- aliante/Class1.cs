using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
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
        public List<Componente> componente;
        public Aliante()
        {
            componente = new List<Componente>();
        }   

        public virtual void descrizione(Componente componente)
        {
            this.componente.Add(componente);
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
        public virtual void descrizione(double lunghezza, double apertura, double costo)
        {
            Console.WriteLine("lunghezza: "+lunghezza+"apertura: "+apertura+"costo: "+costo);
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
        private double _lunghezza;
        private double _materiale;
        public Fusioliera(double lunghezza, double materiale)
        {
            this._lunghezza = lunghezza;
            this._materiale = materiale;
        }

        public void descrizione(double lunghezza, double materiale)
        {
            Console.WriteLine("lunghezza: " + lunghezza + "materiale: "+ materiale);
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
