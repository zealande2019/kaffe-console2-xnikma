using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class FlatWhite : Kaffe, Imælk
    {
        /// <summary>
        /// Hvor meget mælk skal bruges til Latte
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 160;
        }

        public override int Pris()
        {
            return 45;
        }

        public override string Styrke()
        {
            return "mild";
        }
        public override string Navn()
        {
            return "Flat White";
        }


    }
}
