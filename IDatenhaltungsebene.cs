using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lagerverwaltung
{
    interface IDatenhaltungsebene
    {
        abstract static List<Artikel> Suche_Artikel_DHE (Artikel artikel);
        /*es wird nur nach parametern gefiltert, die ausgefüllt sind, ist
         *z.b. nur die Bezeichnung gefüllt, dann sind Artikelnummer und Beschreibung keine Suchparameter*/
        abstract static bool Anlage_Artikel_DHE(Artikel artikel);
        //rückmeldung ob es irgendwelche fehler gab, z.b. primaerschluessel bereits in verwendung
        abstract static bool Aendern_Artikel_DHE(Artikel artikel);
        //siehe kommentar Anlage_Artikel
        abstract static List<Lagerplatz> Suche_Lagerplaetze_DHE(Lagerplatz lagerplatz);
        //siehe kommentar Suche_Artikel
        abstract static bool Wareneingang_buchen_DHE(Lagerplatz lagerplatz);
        //rückmeldung ob es irgendwelche fehler gab, z.b. lagerplatz enthält bereits anderen artikel
        abstract static bool Warenausgang_buchen_DHE(Lagerplatz lagerplatz);
        //rückmeldung ob es irgendwelche fehler gab, z.b. lagerplatz enthält anderen artikel oder zu wenig vom artikel
    }
}
