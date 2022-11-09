using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kapsul
{
    public class kapsul
    {
        private int en;
        private int boy;



        public int EN
        {

            get 
            { 
                return en; 
            }
        
         set
        {
                if (value < 0)
                {
                    Console.WriteLine("yanlis deger girdiniz lutfen pozitif sayi giriniz");
                }
                 else 
                 {  
                    en = value; 
                 }

            
        }


        }
        public int BOY
        {
            get { return boy; }
            set 
            { 
                if (value < 0)
                {
                    boy = 0;
                }
                else
                {
                    boy = value;
                }
            }    

        }



        public int al()
        {
            return BOY + EN;
        }
        public int MyProperty { get; set; }

    }
        
        
    
}
