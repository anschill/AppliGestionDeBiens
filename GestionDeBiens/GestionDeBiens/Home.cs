using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeBiens
{
    //HOME HERITE DE REALTY//
    public class Home : Realty
    {
        private int rooms;
        // :base PERMET DE RENVOYER LES VALEURS A LA CLASS PARENT //
        public Home(int _registerNumber, String _location, int _area, Double _rent, int _rooms) : base(_registerNumber, _location, _area, _rent)
        {
            rooms = _rooms;
        }
        //ON RESURCHARGE LA METHODE QUE L'ON A CREE DANS LA CLASS PARENT, LE base PERMET DE RENVOYER LES VALEURS AU PARENT//
        public override string ToString()
        {
            return base.ToString() + "Nombre de pièces :  " + rooms;
        }

    }
}