using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class Stapel<R>
    {
        private List<R> Stapellijst = new List<R>();
        private List<R> stapellijstCopy = new List<R>();


        public void OpDeStapel(R toeTeVoegen)
        {
            Stapellijst.Add(toeTeVoegen);
        }

        public R vanDeStapel()
        {
            if (Stapellijst.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            R updatedLijst = Stapellijst[Stapellijst.Count - 1];
            Stapellijst.RemoveAt(Stapellijst.Count - 1);

            return updatedLijst;
        }

        public void StapelLeegMaken()
        {
            Stapellijst.Clear();
        }


        public bool IsAanwezigOpStapel(R tezoeken)
        {
            foreach (R elements in Stapellijst)
            {

                if (elements.ToString() == tezoeken.ToString())
                {

                    return true;

                }

            }

            return false;

        }

        public override string ToString()
        {
            string lijst = "";

            foreach (R t in Stapellijst)
            {
                lijst += t.ToString() + " " + ",";
            }

            return lijst;
        }

        public List<R> lijstCopy()
        {
            stapellijstCopy = Stapellijst.GetRange(0, Stapellijst.Count);

            return stapellijstCopy;
        }
    }
}
