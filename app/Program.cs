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
            string s="", risultato="";
            int n=0;
            switch (smistamento){
                case 1: 
                    Console.WriteLine("Inserisci la stringa da cifrare: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Inserisci la chiave di cifratura: ");
                    n = int.Parse(Console.ReadLine());

                    risultato = Cifratura(s, n);
                    if(risultato == "")
                    {
                        Console.WriteLine("Semaforo rosso, Errore: risultato vuoto");
                    }
                    else{
                        Console.WriteLine("La stringa criptata è: " + risultato);
                    }
                    break;
                case 2: 
                    Console.WriteLine("Inserisci la stringa da decifrare: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Inserisci la chaive di decifratura: ");
                    n = int.Parse(Console.ReadLine());

                    risultato = Decifratura(s, n);
                    if(risultato == "")
                    {
                        Console.WriteLine("Semaforo rosso, Errore: risultato vuoto");
                    }
                    else{
                        Console.WriteLine("La stringa decriptata è: " + risultato);
                    }
                    break;
                case 3: 
                    Console.WriteLine("Inserisci la stringa di cui calcolare il valore: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Inserisci la chaive di cifratura: ");
                    n = int.Parse(Console.ReadLine());

                    risultato =  calcValore(s, n);
                    if(risultato == "")
                    {
                        Console.WriteLine("Semaforo rosso, Errore: risultato vuoto");
                    }
                    else{
                        Console.WriteLine("Il risultato è: " + risultato);
                    }
                    break;
                case 4: 
                    Console.WriteLine("Inserisci la stringa di cui calcolare il valore: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Inserisci la chaive di cifratura: ");
                    n = int.Parse(Console.ReadLine());

                    risultato =  calcValore_4(s, n);
                    if(risultato == "")
                    {
                        Console.WriteLine("Semaforo rosso, Errore: risultato vuoto");
                    }
                    else{
                        Console.WriteLine("Il risultato è: " + risultato);
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
                    //nel caso sia presente nella stringa da cifrare un carattere
                    //non compreso nell'alfabeto, esso verrà trascritto ma senza essere cifrato
                    risultato += c;
                }
            }
            return risultato;
        }

        public static string Decifratura(string s, int n)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string risultato = "";
            foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = (posizione - n + alfabeto.Length) % alfabeto.Length;
                    risultato += alfabeto[posizione];
                }
                else
                {
                    risultato += c;
                }
            }
            return risultato;
        }

        public static string calcValore(string s, int n)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string risultato="";
            int sommaValStringa= 0;
            foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = posizione + 1;
                    sommaValStringa += posizione;
                }
                else
                {
                    sommaValStringa += 0;
                }
            }
            sommaValStringa = sommaValStringa * n;
            risultato = sommaValStringa.ToString();
            return risultato;
        }

        public static string calcValore_4(string s, int n)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string risultato="";
            double sommaValStringa= 1;
            foreach (char c in s)
            {
                int posizione = alfabeto.IndexOf(c);
                if (posizione >= 0)
                {
                    posizione = posizione + 1;
                    sommaValStringa *= posizione;
                }
                else
                {
                    sommaValStringa += 0;
                }
            }
            sommaValStringa = sommaValStringa / n;
            int arrotondato = (int)sommaValStringa;
            if (sommaValStringa > arrotondato)
            {
                arrotondato++;
            }
            risultato = arrotondato.ToString();
            return risultato;
        }
    }
}