using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.modelo
{
    class Login
    {
        public static bool login(String user, String pass)
        {
            string line;
            String[] data;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"data.ccg");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                data=line.Split(';');
                if (data[0] == user)
                {
                    if (data[1] == pass)
                        return true;
                    else
                        return false;
                }
                    
            }
            return false;

            

        }
           
    }
}
