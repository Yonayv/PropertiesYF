using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesYF
{
   
    /// <summary>
    /// Car is our class that we access.
    /// We access our model by applying private and public string
    /// Get and set is used to return the model to its set value
    /// The public string make was made public so we could access this code in our program
    /// </summary>
    class Car
    {

        private string model;

        public string Model { get { return model; } set { model = value; } }

        public string Make { get; set; }
    }
}
