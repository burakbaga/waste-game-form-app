using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpodev
{
    class Atik : IAtik

    {
        public Atik()
        {

        }

        public Atik(int hacim,Image image,string name)
        {
            _hacim = hacim;
            _image = image;
            _name = name;
        }

        private int _hacim;
        private Image _image;
        private string _name;
        public int Hacim
        {
            get => _hacim;
            set
            {
              
            }
        }
        public string Name
        {
            get => _name;
            
            set
            {

            }
        }
        public Image Image
        {
            get => _image;
            set
            {
             
            }
        }

    }
}
