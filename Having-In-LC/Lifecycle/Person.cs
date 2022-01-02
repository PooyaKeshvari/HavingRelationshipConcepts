using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Having_In_LC.Lifecycle
{
    public class Person
    {
        #region [-Ctors-]
        //This Region is For Eager subType.
        //public Person()
        //{

        //}
        public Person()
        {
          //  Ref_Hand = new Hand(); //eager Composition : new in body. \When Person Build Have Hand.
        }

        public Person(Pen ref_Pen)
        {
            Ref_Pen = ref_Pen; //eager Aggregation
        }

        #endregion

        #region [-Props-]
        //Having is create prop from Concept .
        public Hand Ref_Hand { get; set; }//State Type Having . //Hand is Composition Type//Person Has Hand
        public Pen Ref_Pen { get; set; }//    "     //Pen is Aggrigation Type//Person Has Pen

        //Third Relation in Having is Associated , and Thats Scope is On Method.
        #endregion

        #region [-Immediate-]
        //Hand Ref_Hand = new Hand();     //Anti Pattern: Memory Up.
        #endregion

        #region [-Methods-]
        // This Region is For Lazy subType.
        #region [-InitializeHand()-] -Composition
        public void InitializeHand()
        {
            Ref_Hand = new Hand(); //Lazy Composition 
        }
        #endregion

        #region [-InitializePen(Pen ref_Pen)-] -Aggregation
        public void InitializePen(Pen ref_Pen)
        {
            Ref_Pen = ref_Pen; //Lazy Aggregation 
        }
        #endregion

        #region [-WriteWithPencil()-] -Association
        public Pencil WriteWithPencil()
        {
            return new Pencil(); //Association  
            //everithing thats write after of return is not on your body , is your return.
        }
        #endregion

        #endregion




    }
}
