using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mini_netflix
{
    public class Serie
    {
        private string titolo;
        private Regista regista;
        private string genere;
        private int annoUscita;
        private int minuti;
        private int episodi;
        private double valutazione;
        private bool doppiata;
        private bool sottotitoliItaliano;


        // Costruttori
        public Serie(string titolo, Regista regista, string genere, int minuti, int episodi, int annoUscita, float valutazione, bool doppiata = false, bool sottotitoliItaliano=false)
        {
            this.titolo = titolo;
            this.regista = regista;
            this.genere = genere;
            this.annoUscita = annoUscita;
            this.minuti = minuti;
            this.episodi = episodi;
            this.doppiata = doppiata;
            this.sottotitoliItaliano = sottotitoliItaliano;
            this.valutazione = valutazione;

        }
        
        // Getters
        public string GetTitolo()
        {
            return this.titolo;
        }
        public int GetDurata()
        {
            return this.minuti;
        }

        public int GetEpisodi()
        {
            return this.episodi;
        }

        public bool GetDoppiaggio()
        {
            return this.doppiata;
        }

        public bool GetSottotitoli()
        {
            return this.sottotitoliItaliano;
        }

        public double GetRecensione()
        {
            return this.valutazione;
        }


        //Setters

        public void SetRecensione(float valutazione)
        {
            if (valutazione > 5)
            {
                Console.WriteLine("5 è la valutazione massima");
            }
            else
            {
                this.valutazione = valutazione;
            }
        }

        // METODI PUBBLICI

        public void Doppiata()
        {
            this.doppiata = true;
        }
        public void Sottotitolato()
        {
            this.sottotitoliItaliano = true;
        }

        public string GetSerie()
        {
            string film;
            film = "-----" + this.titolo + "-----\ndi " + this.regista.GetStringaRegista() + "\n\n" + "Episodi: " + this.episodi + "episodi da " + this.minuti + " minuti\nGenere: " + this.genere + "\nAnnoUscita: " + this.annoUscita + "\nValutazione: " + this.valutazione + "/5\nDoppiata: " + YerOrNot(this.doppiata) + "\nSottotitolata: " + YerOrNot(this.sottotitoliItaliano);
            return film;
        }


        // METODI PRIVATI

        private string YerOrNot(bool boolean)
        {
            if (boolean)
            {
                return "Sì";
            }
            else
            {
                return "No";
            }
        }
    }

}
