using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeBiens
{
    //Parking HERITE de Realty, elle obtient ses propriétés
    public class Parking : Realty
    {
        //on lui donne les paramètres de la classe PARENT
        //base permet de renvoyer les paramètres au parent
        public Parking(int _registerNumber, String _location, int _area, Double _rent) :base(_registerNumber, _location, _area, _rent)
            {
            }
    }
}
