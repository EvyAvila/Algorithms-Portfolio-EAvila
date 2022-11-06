using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVsMap
{
    public interface IExampleComponents
    {
        //An interface that inserts the main componets for displaying the examples
        //that I noticed were reuseable.
        public string ExternalFileName { get; set; }

        public string[] GetExternalFile { get; set; }

        public void SetValue();

        public void DisplayValue();
    }
}
