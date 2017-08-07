using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demineur.Models
{
    class Case
    {
        public int posX;
        public int posY;

        public int? caseValue;

        public bool isMine
        {
            get
            {
                return caseValue == null;
            }
        }

        Case(int x, int y, int? casevalue = null)
        {
            posX = x;
            posY = y;
            caseValue = casevalue;
        }
    }
}
