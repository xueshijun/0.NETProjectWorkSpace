using System;
using System.Collections.Generic; 
using System.Text;

namespace Entitys
{
    public class Admins : User
    {
       private string pass;

       private string count;



       public string ID
       {
           get { return id; }
           set { id = value; }
       }
       public string Name
       {
           get {  return name;  }
           set {  name = value; }
       }
       public string Pass
       {
           get { return pass; }
           set { pass = value; }
       }

       public string Count
       {
           get { return count; }
           set { count = value; }
       }
        
       public string Role
       {
           get { return "admin"; } 
       }
    }
}
