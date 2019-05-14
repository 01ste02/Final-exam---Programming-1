using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprov
{
    class Företag
    {
        private string namn;
        private int antalAnställda;

        public Företag (string namn, int antalAnställda)
        {
                Namn = namn;
                AntalAnställda = antalAnställda;
        }

        public string Namn
        {
            get
            {
                return namn;
            }

            set
            {
                try //Se till att företagsnamnet är en string, och så att programmet inte kraschar om det inte är det.
                {
                    namn = value;
                }
                catch
                {

                }
            }
        }

        public int AntalAnställda
        {
            get
            {
                return antalAnställda;
            }

            set
            {
                try //Om value inte är en int ska programmet ej krascha. Antal anställda kan inte vara mindre än noll, så om value är mindre än det bör antalAnställda bli 0.
                {
                    if (value >= 0)
                    {
                        antalAnställda = value;
                    }
                    else
                    {
                        antalAnställda = 0;
                    }
                }
                catch
                {

                }
            }
        }
    }
}
