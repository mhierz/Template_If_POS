using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_If_POS.Classes
{
    public static class AgeManager
    {
        /// <summary>
        /// In dieser Funktion wird eine Warnung ausgegeben, wenn das Alter über 16 bzw. über 18 liegt.
        /// </summary>
        /// <param name="age"></param>
        public static void ShowAgeWarning(int age)
        {
            
            //Führe diesen Befehl aus, wenn das Mindestalter größer oder gleich 16 Jahre ist!
            MessageBox.Show("Der Käufer muss mindestens " + age + "Jahre alt sein!", "Alterscheck!");
        }
    }
}
