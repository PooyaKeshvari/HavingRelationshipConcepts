using Having_In_LC.Lifecycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Having_In_LC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [-Eager-]
            #region [-Eager Composition-]
            //Person ref_Person1 = new Person();
            //ref_Person1.Ref_Hand.Finger = "Index";
            #endregion
       
            #region [-Eager Aggregation-]
            Person ref_Person2 = new Person(new Pen());
            ref_Person2.Ref_Pen.Color = "Red";
            #endregion
            #endregion
  
            #region [-Lazy-]
            #region [-Lazy Composition-]
            Person ref_Person3 = new Person();
            ref_Person3.InitializeHand();
            ref_Person3.Ref_Hand.Finger = "Second Finger";
            #endregion

            #region [-Lazy Agregation-]
            Person ref_Person4 = new Person();
            ref_Person4.InitializePen(new Pen());
            ref_Person4.Ref_Pen.Color = "Yellow";
            #endregion
            #endregion

            #region [-Late_Association-]
            Person ref_Person5 = new Person();
            ref_Person5.WriteWithPencil().Color = "Black";
            #endregion

        }
    }
}
