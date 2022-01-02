using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Having_In_LC.Lifecycle
{
   public class Hand
    {

        #region [-ctor-]
        public Hand()
        {

        }
        #endregion

        #region [-props-]
        public string Finger { get; set; }
        #endregion

        #region [-Methods-]
        public void HandShake()
        {
            Console.WriteLine("Shaking Hand For Sun... .");
        }
        #endregion
    }
}
