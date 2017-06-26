using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;



namespace WcfServiceCC
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CandyCrushService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CandyCrushService.svc o CandyCrushService.svc.cs en el Explorador de soluciones e inicie la depuración.
    
    public class CandyCrushService : ICandyCrushService
    {


        public void setScore(int score, string user)
        {
            

            System.IO.Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);

            StreamReader lectura = new StreamReader(@"C:\dataCC\data.txt");
            StreamWriter escritura = new StreamWriter(@"C:\dataCC\dataTemporal.txt");

 
            string line;
            string pass;
            int bestScore;
            while ((line = lectura.ReadLine()) != null)
            {
                string[] campos = line.Split(';');
                if (campos[0] == user)
                {
                    pass = campos[1];
                    bestScore = int.Parse(campos[2]);

                    if (score > bestScore)
                    {
                        campos[2] = score + "";
                    }
                    
                    string reemplazo = campos[0] + ";" + campos[1] + ";" + campos[2] + ";" + score;
                    escritura.WriteLine(reemplazo);
                }
                else escritura.WriteLine(line);
            }
            lectura.Close();
            escritura.Close();

            copyFile();


        }


        private void copyFile()
        {
            StreamReader lectura = new StreamReader(@"C:\dataCC\dataTemporal.txt");
            StreamWriter escritura = new StreamWriter(@"C:\dataCC\data.txt");
            string line;
            while ((line = lectura.ReadLine()) != null)
            {
                escritura.WriteLine(line);
            }
            lectura.Close();
            escritura.Close();

        }

        public bool login(string user, string pass)
        {
            string line;
            String[] data;
            StreamReader file;
            try
            {
                file = new StreamReader(@"C:\dataCC\data.txt");
            }
            catch
            {
                return false;
            }
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                data = line.Split(';');
                if (data[0] == user)
                {
                    if (data[1] == pass)
                    {
                        file.Close();
                        return true;
                    }
                    else
                    {
                        file.Close();
                        return false;
                    }
                }

            }
            file.Close();
            return false;
        }



        public bool register(string user, string pass)
        {
            System.IO.Directory.CreateDirectory(@"C:\dataCC");
            if (File.Exists(@"C:\dataCC\data.txt"))
            {
                System.IO.StreamReader fileR = new System.IO.StreamReader(@"C:\dataCC\data.txt");

                if (existeUser(fileR, user))
                {
                    fileR.Close();
                    return false;
                }
                fileR.Close();
            }
            StreamWriter file = new StreamWriter(@"C:\dataCC\data.txt", true);

            file.WriteLine(user + ";" + pass + ";0;0");
            file.Close();
            return true;

        }

        private bool existeUser(StreamReader file, String user)
        {
            string line;
            String[] data;
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                data = line.Split(';');
                if (data[0] == user)
                {
                    return true;
                }

            }
            return false;
        }

    }
}
