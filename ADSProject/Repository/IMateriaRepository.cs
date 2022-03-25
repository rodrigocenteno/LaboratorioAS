using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Repository
{
    public interface IMateriaRepository
    {
        List<MateriaViewModel> obtenerMateria();

        int agregarMateria(MateriaViewModel materiaViewModel);

        int ActualizarMateria(int idMateria, MateriaViewModel materiaViewModel);

        bool eliminarMateria(int idMateria);

        MateriaViewModel obtenerMateriaPorID(int idMateria);
    }
}