using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrusascaEdCivicaTIPSI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funzione da eseguire: ");
            int smistamento = int.Parse(Console.ReadLine());
            string s, risultato;
            int n;
            switch (smistamento){
                case 1: 
                    Console.WriteLine("Inserisci la stringa da cifrare: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Inserisci il numero di posizioni da spostare: ");
                    n = int.Parse(Console.ReadLine());

                    risultato = Cifratura(s, n);
                    if(risultato == "")
                    {
                        Console.WriteLine("Semaforo rosso, Errore: risultato vuoto");
                    }
                    else{
                        Console.WriteLine(risultato);
                    }

                    break;
            }
        }

        public static string Cifratura(string s, int n)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string risultato = "";
            foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = (posizione + n) % alfabeto.Length;
                    risultato += alfabeto[posizione];
                }
                else
                {
                    risultato += c;
                }
            }
            return risultato;
        }  
    }
}