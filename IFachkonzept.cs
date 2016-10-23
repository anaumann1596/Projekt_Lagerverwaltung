using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lagerverwaltung
{
    interface IFachkonzept
    {
        abstract static List<Artikel> Suche_Artikel_FK(Artikel artikel);
        abstract static bool Anlage_Artikel_FK(Artikel artikel);
        abstract static bool Aendern_Artikel_FK(Artikel artikel);
        abstract static List<Lagerplatz> Suche_Lagerplaetze_FK(Lagerplatz lagerplatz);
        abstract static bool Wareneingang_buchen_FK(Lagerplatz lagerplatz);
        abstract static bool Warenausgang_buchen_FK(Lagerplatz lagerplatz);
    }
}
