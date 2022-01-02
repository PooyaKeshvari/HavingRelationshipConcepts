using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Having_In_LC.Lifecycle
{
    public class Pen
    { 
        #region [-ctor-]
        public Pen()
        {

        }
        #endregion

        #region [-props-]
        public string Color { get; set; }
        #endregion

        #region [-Methods-]
        public void Smell()
        {
            Console.WriteLine("Smelling Pen");
        }
        #endregion
    }
}
