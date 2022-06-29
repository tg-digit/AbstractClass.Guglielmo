using System;
using System.Collections.Generic;

namespace EsercizioCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Bruno", 40, "brngki876");
            Cliente cliente2 = new Cliente("Antonio", 50, "antgki876");
            Cliente cliente3 = new Cliente("Marco", 30, "mrcgki876");
            Cliente cliente4 = new Cliente("Chiara", 40, "chrgki876");

 
            BancaClienti banca = new BancaClienti();// Creo l'oggetto Cliente Contenitore
            banca.AddCliente(cliente1);
            banca.AddCliente(cliente2);
            banca.AddCliente(cliente3);
            banca.AddCliente(cliente4);

            Console.WriteLine("*** Report clienti bancari con età maggiore di 36 anni ***");

            foreach (var item in banca._cliente)
            {
                if(item._age > 36)
                {
                    Console.WriteLine("Nome cliente : " + item._name + " - Età : " + item._age + " - Cod. Fisc. : " + item._codfiscale);
                }
            }

        }
    }

    public class BancaClienti
    {
        public List<Cliente> _cliente = new List<Cliente>(); // Collection

        public BancaClienti()
        {

        }
        public void AddCliente(Cliente cliente)
        {
            _cliente.Add(cliente);

        }

    }
    public class Cliente
    {
        public string _name;
        public int _age;
        public string _codfiscale;


        // Property
        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public string Codfiscale { get { return _codfiscale; } }


        public Cliente(string Name, int Age, string Codfiscale)
        {
            _name = Name;
            _age = Age;
            _codfiscale = Codfiscale;
        }

    }


    // CONTO
    public class BancaConto
    {
        public List<Conto> _cliente = new List<Conto>(); // Collection

        public BancaConto()
        {

        }
        public void AddConto(Conto conto)
        {
            _cliente.Add(conto);

        }

    }
    public class Conto
    {
        public string _name;
        public int _saldo;


        // Property
        public string Name { get { return _name; } }
        public int Saldo
        {
            get
            {
                return _saldo;
                ;
            }
        }


        public Conto(string Name, int Saldo)
        {
            _name = Name;
            _saldo = Saldo;
        }

    }

}

