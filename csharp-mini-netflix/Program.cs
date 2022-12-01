// See https://aka.ms/new-console-template for more information

using csharp_mini_netflix;

Regista regista1 = new Regista("Pinco", "Pallo", 26);

Console.WriteLine(regista1.GetStringaRegista());

regista1.SetNome("Caio");
regista1.SetCognome("Ciaociao");
regista1.SetEta(-2);

Console.WriteLine(regista1.GetStringaRegista());

Console.WriteLine(regista1.GetDeceduto());
regista1.Deceduto();
Console.WriteLine(regista1.GetDeceduto());


Serie Serie1 = new Serie("Le mirabolanti avventure di pinco pallo", regista1, "avventura", 30, 8, 1995, 5.5f);
Console.WriteLine(Serie1.GetSerie());

Film Film1 = new Film("PincoPallo-La Vendetta", regista1, "azione", 2012, 120, 4.5);
Console.WriteLine(Film1.GetFilm());

