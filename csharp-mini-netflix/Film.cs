using csharp_mini_netflix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mini_netflix
{
    public class Film
   
    {
        // PROPRIETA / ATTRIBUTI
        private string titolo;
        private Regista regista;
        private string genere;
        private int annoUscita;
        private int minuti;
        private double valutazione;
        private bool doppiata;
        private bool sottotitoliItaliano;



        // COSTRUTTORI
        public Film(string titolo, Regista regista, string genere, int annoUscita, int minuti, double valutazione, bool doppiata = false,bool sottotitoliItaliano = false)
        {
            this.titolo = titolo;
            this.regista = regista;
            this.genere = genere;
            this.annoUscita = annoUscita;
            this.minuti = minuti;
            this.valutazione = valutazione;
            this.doppiata = doppiata;
            this.sottotitoliItaliano = sottotitoliItaliano;
        }
        //Getters

        public string GetTitolo()
        {
            return this.titolo;
        }
        public string GetRegista()
        {
            return this.regista.GetStringaRegista();
        }
        public string GetGenere()
        {
            return this.genere;
        }

        public int GetAnnoUscita()
        {
            return this.annoUscita;
        }
        public int GetMinuti()
        {
            return this.minuti;
        }
        public double GetValutazione()
        {
            return this.valutazione;
        }
        public bool GetDoppiata()
        {
            return this.doppiata;
        }
        public bool GetSottotitoliItaliano()
        {
            return this.doppiata;
        }

        // SETTERS



        public void SetValutazione(double valutazione)
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

        public string GetFilm()
        {
            string film;
            film = $@"
-----{this.titolo}-----
di {this.regista.GetStringaRegista()}

Durata: {this.minuti} minuti
Genere: {this.genere}
AnnoUscita: {this.annoUscita}
Valutazione: {this.valutazione}/5
Doppiata: {YerOrNot(this.doppiata)}
Sottotitolata: {YerOrNot(this.sottotitoliItaliano)}

";
            return film;
        }

        // METODI PRIVATI

        private string YerOrNot(bool boolean)
        {
            if (boolean)
            {
                return "Sì";
            } else
            {
                return "No";
            }
        }
    }
}
