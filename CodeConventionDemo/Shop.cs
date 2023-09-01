using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeConventionDemo
{
	public class Shop
	{
        private string _name; // try rename remove underscore prefix and rebuild to see error
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

		public Shop() {
			_name = "Tom";
		}
	}
}
