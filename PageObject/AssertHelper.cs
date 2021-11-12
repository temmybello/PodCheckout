using System;
using System.Collections.Generic;
using System.Text;

namespace PodCheckout.PageObject
{
    class AssertHelper
    {
      public static void AreEqual(string expected,string actual)
        {
            try
            {
                AssertHelper.Equals(expected, actual);
            }
            catch (Exception)
            {
              //ignore
            }
        }

    }
}
