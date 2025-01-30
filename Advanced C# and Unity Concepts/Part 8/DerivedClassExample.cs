using UnityEngine;

namespace Assignment35
{
    public class DerivedClassExample : AbstractBaseClass
    {
        public override void PerformAction()
        {
            Debug.Log("PerformAction is implemented in the derived class.");
        }

        public void PrintInfo()
        {
            Debug.Log("This is a concrete method in the abstract base class.");
        }
    }
}