using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modulo3
{
   public  class AsyncMethods
    {
        public async Task SaveEstudiante(Estudiante estud)
        {
            using (var context = new ApplicationDbContext())
            {
                await context.AddAsync(estud);
                await context.SaveChangesAsync();
            }
        }
        public async Task SaveEstudiantesList(List<Estudiante> estuds)
        {
            using (var context = new ApplicationDbContext())
            {
                foreach (var est in estuds)
                {
                    await context.AddAsync(est);
                }                
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<Estudiante>> GetAllEstudiantes()
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Estudiantes.ToListAsync();
            }
        }
        public async Task<Estudiante> GetEstudianteByID(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Estudiantes.FirstOrDefaultAsync(x => x.Id == id);
            }
        }

    }
}
