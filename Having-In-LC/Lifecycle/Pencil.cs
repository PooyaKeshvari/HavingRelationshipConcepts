using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Having_In_LC.Lifecycle
{
   public class Pencil
    {
        #region [-ctor-]
        public Pencil()
        {

        }
        #endregion

        #region [-props-]
        public string Color { get; set; }
        #endregion

        #region [-Methods-]
        public void Write()
        {
            Console.WriteLine("Write With Pencil... .");
        }
        #endregion
    }
}
