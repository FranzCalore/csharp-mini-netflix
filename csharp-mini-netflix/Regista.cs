using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mini_netflix
{
    public class Regista
    {
        private string nome;
        private string cognome;
        private int età;
        private bool inAttività;
        private bool deceduto;

        // COSTRUTTORI

        public Regista(string nome, string cognome, int età, bool inAttività = true, bool deceduto = false)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.età = età;
            this.inAttività = inAttività;
            this.deceduto = deceduto;
        }

        // GETTERS

        public string GetNome()
        {
            return this.nome;
        }

        public string GetCognome()
        {
            return this.cognome;
        }

        public int GetEta()
        {
            return this.età;
        }

        public bool GetInAttivita()
        {
            return this.inAttività;
        }

        public bool GetDeceduto()
        {
            return this.deceduto;
        }

        // SETTERS

        public void SetNome(string nome)
        {
            if (nome == "" || nome == " ")
            {
                Console.WriteLine("Il campo nome non può essere inserito vuoto");
            }
            else
            {
                this.nome = nome;
            }
        }
        public void SetCognome(string cognome)
            {
                if (cognome == "" || cognome == " ")
                {
                    Console.WriteLine("Il campo cognome non può essere inserito vuoto");
                }
                else
                {
                    this.cognome = cognome;
                }
            }
        public void SetEta(int età)
        {
            if (età<=0)
            {
                Console.WriteLine("L'età non può essere pari o inferiore a 0");
            } else
            {
                this.età = età;
            }
        }
        public void SetInAttivita (bool inAttivita)
        {
            this.inAttività = inAttivita;
        }

        // METODI PUBBLICI

        public void Deceduto()
        {
            this.deceduto = true;
        }

        public string GetStringaRegista()
        {
            string nomeCompleto;
            nomeCompleto = this.nome + " " + this.cognome + ", " + this.età;
            return nomeCompleto;
        }

        // METODI PRIVATI
    }
}
