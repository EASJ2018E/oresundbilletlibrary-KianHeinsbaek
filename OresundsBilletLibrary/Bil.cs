using System;
using BilletLibrary;

namespace OresundsBilletLibrary
{
    public class Bil : KøretøjSuperClass
    {
        public override double Pris()
        {
            return 410;
        }

        public override string Køretøj()
        {
            return "Øresund Bil";
        }

        public override double BroBizz()
        {
            return 161;
        }
    }
}
