using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KadetServiceProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class KadryService : IKadryService
    {
        WCFFirma firma;

        public KadryService()
        {
            firma = new WCFFirma();
        }

        public Pracownik DodajPracownika(Pracownik pracownik, string haslo)
        {
            pracownik.Haslo = haslo;
            firma.Pracownicy.Add(pracownik);
            firma.SaveChanges();
            return pracownik;
        }

        public void ModyfikujPracownika(Pracownik pracownik, string pesel)
        {
            Pracownik pracownikUpdate = firma.Pracownicy.Where(p => p.Pesel.Equals(pesel)).Single();
            pracownikUpdate.Imie = pracownik.Imie;
            pracownikUpdate.Nazwisko = pracownik.Nazwisko;
            pracownikUpdate.Email = pracownik.Email;
            firma.SaveChanges();
        }

        public void UsunPracownika(string pesel)
        {
            firma.Pracownicy.Remove(firma.Pracownicy.Where(p => p.Pesel.Equals(pesel)).Single());
            firma.SaveChanges();
        }

        public Pracownik[] WyszukajPracownika(string fraza)
        {
            return firma.Pracownicy
                .Where(p=>p.Imie.Contains(fraza) || p.Nazwisko.Contains(fraza) || p.Numer.Contains(fraza) || p.Pesel.Contains(fraza))
                .ToArray();
        }
    }
}
