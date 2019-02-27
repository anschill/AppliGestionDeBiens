using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeBiens
{
    //une abstract class est un modèle, elle ne peut pas être utilisée seule //
    public abstract class Realty
    {
        //MODIFICATEURS D'ACCES                                                         //
        //protected = peut être modifiée depuis la classe ou par une classe enfant      //  
        //public = est accessible de n'importe où dans le programme                     //
        //private = ne peut être modifié qu'à partir de la classe                       //
        public int registerNumber;
        protected String location;
        protected int area;
        protected Double rent;

        public Realty(int _registerNumber, String _location, int _area, Double _rent)
        {
            //ou this.registerNumber = _registerNumber
            registerNumber = _registerNumber;
            location = _location;
            area = _area;
            rent = _rent;
        }

        //methode SURCHARGEE
        public override string ToString()
        {
            //base = class parent
            return "Numéro d'enregistrement : " + registerNumber + "\nLocalisation : " + location + "\nSuperficie : " + area + "\nLoyer : " + rent;
        }
    }
}
