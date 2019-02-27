using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeBiens
{
    //FLAT HERITE DE REALTY//
    public class Flat : Realty
    {
        private int rooms;
        private int floors;
     // :base PERMET DE RENVOYER LES VALEURS A LA CLASS PARENT //
        public Flat(int _registerNumber, String _location, int _area, Double _rent, int _rooms, int _floors) : base(_registerNumber, _location, _area, _rent)
        {
            rooms = _rooms;
            floors = _floors;
        }
        //ON RESURCHARGE LA METHODE QUE L'ON A CREE DANS LA CLASS PARENT, LE base PERMET DE RENVOYER LES VALEURS AU PARENT//
        public override string ToString()
        {
            return base.ToString() + "Nombre de pièces :  " + rooms + "\nEtages : " + floors;
        }

    }
}
