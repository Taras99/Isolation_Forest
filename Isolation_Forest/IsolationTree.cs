using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Isolation_Forest
{
    public  class IsolationTree
    {


        List<string> Property_List { get; set; }

        
        // value that saves random property for object Input_data
        string randomProp { get; set; }



        // function get random value from class
        public void Get_property( List<string> propert, Input_data obj)
        {
            
            Type t = typeof(Input_data);
            PropertyInfo[] properties = t.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Property_List.Add(property.Name);
            }
        }

        public string Get_random_property(List<string> propert)
        {

            Random rnd = new Random();
            int index = rnd.Next(0,Property_List.Count);
            string randomProp = Property_List[index];
            return randomProp;    
        }

        public string  Get_random_value(Input_data obj,string random_property)
        {
            Random rnd = new Random();
            var index = rnd.Next(obj.);
            // need find solution

            

            var random_Value = "0";
            return random_Value;
        }

        public void Spliting_sample(List<Input_data> Object_list) 
        {

            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                Console.WriteLine(type.Name);
            }

            // How to split difference category of data


            //split a sample by split value

            //Question : how to beter save splited collections

        }






}
}
