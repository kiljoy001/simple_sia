using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
/// <summary>
/// This class has a dictionary property that will return the name of the field and the object associated with it. It uses reflection to get the name and object. 
/// </summary>
namespace simple_sia_connect.Classes.Helper
{
    public class PropertyReflector
    {
        public Dictionary<string, object> ReturnValue {get; set;}
        private string name;
        private object inputed_object;
        public PropertyReflector(object subject)
        {
            Type reflect = subject.GetType();
            PropertyInfo[] ListAll = reflect.GetProperties();
            foreach (PropertyInfo pi in ListAll)
            {
                name = pi.Name;
                inputed_object = pi.GetValue(pi, null);
                ReturnValue.Add(name, inputed_object);
            }
        }
    }
}
