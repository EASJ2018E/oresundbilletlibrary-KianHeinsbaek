using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace OresundsBilletLibrary
{
    class MC : KøretøjSuperClass
    {
        public override double Pris()
        {
            return 210;
        }

        public override string Køretøj()
        {
            return "Øresund MC";
        }

        public override double BroBizz()
        {
            return 73;
        }
    }
}
