using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6._2
{

    //Problem 5. ICloneable for Hotel(Hotel should have a list of Rooms)
    public class Hotel //: ICloneable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public LinkedList<Hotel> hotels { get; set; }
        

        string new1 = new List<Hotel>(a1.Select(x => x.Clone()));

    }
   

   
}
