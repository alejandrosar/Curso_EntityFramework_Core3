using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Estudiante estud = new Estudiante()
            {
                Nombre = "Alex",
                FechaNacimiento = new DateTime(1993, 9, 27)
            };
            AsyncMethods asyncM = new AsyncMethods();
            await asyncM.SaveEstudiante(estud);
            var getAll = await asyncM.GetAllEstudiantes();
            var getID1 = await asyncM.GetEstudianteByID(1);

            List<string> nombres = new List<string>()
            {
                "ADA",
                "ADALBERTO",
                "ADAN",
                "ADELA",
                "ADELAIDA",
                "ADELARDO",
                "ADELINA",
                "ADEMAR",
                "ADOLFO"
            };
            List<Estudiante> estudiantesToAdd = new List<Estudiante>();
            for (int i = 0; i < nombres.Count-1; i++)
            {

                //var nombreFormateado = string.Join(' ', nombres[i].Split(' ')
                //    .Select(x => x[0].ToString().ToUpper() + x.Substring(1).ToLower()).ToArray());
                Estudiante estudi = new Estudiante()
                {
                    Nombre = nombres[i],
                    FechaNacimiento = new DateTime(2000 + i, 9, 15)
                };
                estudiantesToAdd.Add(estudi);
            }
            await asyncM.SaveEstudiantesList(estudiantesToAdd);

            var todosLosEstudiantes = await asyncM.GetAllEstudiantes();




            var stop = "=D";
        }
    }
}
