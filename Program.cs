using ConsoleApp1.InheritanceOdev;

Hayvanlar hayvanlar = new Kedi();
hayvanlar._tur = "Kedi";
hayvanlar._name = "Moka";
hayvanlar._yas = 2;
Console.WriteLine(hayvanlar);
hayvanlar.sesCikar();
Kedi kedi = new Kedi();
kedi.sesCikar();
Kopek kopus = new Kopek();
kopus.sesCikar();

kedi._tur = "Scottish";
kedi._yas = 5;
kedi._name = "Cakil";
Console.WriteLine(kedi);
Hayvanlar Kus = new Kus();
Kus._tur = "Saka";
Kus._name = "Mavis";
Kus._yas = 3;
Kus.sesCikar();
Console.WriteLine(Kus);









