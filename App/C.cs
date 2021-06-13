using sime.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sime.App
{
    public static class C
    {
        public static Color COLOR_CONTROLBOX = Color.FromArgb(128, 64, 64);

        // public static List<Mesa> Mesas = new List<Mesa>();

        public static List<Mesa> Mesas = new List<Mesa>()
        {
                new Mesa()
                {
                    IdMesa = 1,
                    Nombre = "Mesa 1",
                    CantidadSillas = 4,
                    Ocupada = false,
                    Activa = true,
                },

                new Mesa()
                {
                    IdMesa = 2,
                    Nombre = "Mesa 2",
                    CantidadSillas = 8,
                    Ocupada = true,
                    Activa = true,
                },

                new Mesa()
                {
                    IdMesa = 3,
                    Nombre = "Mesa 3",
                    CantidadSillas = 2,
                    Ocupada = false,
                    Activa = true,
                },

                new Mesa()
                {
                    IdMesa = 4,
                    Nombre = "Mesa 4",
                    CantidadSillas = 2,
                    Ocupada = false,
                    Activa = true,
                },

                new Mesa()
                {
                    IdMesa = 5,
                    Nombre = "Mesa 5",
                    CantidadSillas = 2,
                    Ocupada = false,
                    Activa = true,
                },
        };
    }
}
