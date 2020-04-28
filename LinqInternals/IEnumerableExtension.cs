using System;
using System.Collections.Generic;
using System.Text;

namespace LinqInternals
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<T> MyWhere<T>(
            this IEnumerable<T> items,
            Func<T, bool> predicate)
        {
            //So, How are we going to implement this.
            //First, we need to loop through the items,
            //then we need to see if the predicate is successful or not
            //and if the predicate is successful we need to return the
            //value out.

            //var list = new List<T>();

            foreach (var item in items)
            {
                if (predicate(item))
                {
                    //list.Add(item);
                    yield return item;
                }
            }

            //return list;

            //First we'll see how the items are returned in actual WHERE method
            //Let's run and see if we've successfully implemented our Method.

            //This is what we got in our implementation. 
            //All the items were returned even before we looped through evenNumbers

            //In actual implementation of WHERE we got the items as an IEnumerable
            //which we saw in Results View.

            //This is not how we want our WHERE implementation to return the items.

            //So how do we acheive this?

            //Now is the right time to reveal the third constituent. :-)

            //The third main constituent is the keyword 'yield'.
            //Yield keyword yields the return and then continue.
        }
    }
}
