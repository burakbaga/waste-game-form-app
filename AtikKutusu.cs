using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpodev
{
    class AtikKutusu : IAtikKutusu 
    {
        private int _kapasite;
        private int _bosaltmaPuani;
        private int _doluHacim;
        private int _dolulukOrani;


        public int BosaltmaPuani
        {
            get=>_bosaltmaPuani;set { _bosaltmaPuani = value; }
        }
        public int Kapasite { get => _kapasite; set { _kapasite = value; } }
        public int DoluHacim { get => _doluHacim; set { _doluHacim = value; } }
        public int DolulukOrani { get => _dolulukOrani; set { _dolulukOrani = value; } }

    



        public AtikKutusu(int BosaltmaPuanis,int Kapasites,int DoluHacims,int DolulukOranis)
        {
            _bosaltmaPuani = BosaltmaPuanis;
            _kapasite = Kapasites;
            _doluHacim = DoluHacims;
            _dolulukOrani = DolulukOranis;
        }

        public bool Bosalt()
        {
            _dolulukOrani = Convert.ToInt32(((double)_doluHacim / (double)_kapasite) * 100);


            if (_dolulukOrani >= 75) {
                return true;
            }

            else
            {
                return false;
            }
        }

 

        public bool Ekle(Atik atik)
        {
            
           


            if (_doluHacim!= 0)
            {
                _dolulukOrani = Convert.ToInt32((double)(_doluHacim /(double) _kapasite) * 100);

            }


            if (_dolulukOrani < 75)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }

}
