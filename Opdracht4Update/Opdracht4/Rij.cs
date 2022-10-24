using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Opdracht4.Form1;

namespace Opdracht4
{
    internal class Rij<R>
    {
        private List<R> rij = new List<R>();
        private List<R> rijcopie = new List<R>();
        private static int teller;
        public event Tonen tonen;



        public void InDeRij(R element)
        {
            rij.Add(element);
            WhenShow(element);


        }

        public void UitDeRij()
        {

            WhenShow(rij[0]);

            rij.Remove(rij[0]);



        }

        public void Toon()
        {
            teller++;
            WhenShow(rij[teller - 1]);

        }

        public void RijLeegMaken()
        {
            rij.Clear();
        }
        public override string ToString()
        {
            string lijst = "";

            foreach (R t in rij)
            {
                lijst += t.ToString() + " " + ",";
            }

            return lijst;
        }

        public bool CheckIfEmpty()
        {
            if (rij.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<R> lijstCopy()
        {
            rijcopie = rij.GetRange(0, rij.Count);

            return rijcopie;

        }

        public void ZetAchteraan()
        {
            if (rij.Count <= 0)
            {
                throw new Exception();
            }

            R element = rij[teller - 1];
            rij.RemoveAt(teller - 1);
            rij.Add(element);
            teller--;

            WhenShow(element);
        }


        public void WhenShow(object rij)
        {


            if (tonen != null)
            {
                tonen(rij);

            }

        }
    }

    public class Tonen<R>
    {
    }
}
