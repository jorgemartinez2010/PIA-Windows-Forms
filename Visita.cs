using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PIA
{
    class Visita
    {
            public int Codigo;
            public string Nombre;
            public string Apellido;
            public string Matricula;
            public string Modelo;
            public string Estado;
            public string Nombre_R;
            public string Apellido_R;
            public string Calle;
            public int Numero;

            public Visita(int id, string nombre, string apellido, string matricula, string modelo, string estado, string nombre_R,
                string apellido_R, string calle, int numero)
            {
                Codigo = id;
                Nombre = nombre;
                Apellido = apellido;
                Matricula = matricula;
                Modelo = modelo;
                Estado = estado;
                Nombre_R = nombre_R;
                Apellido_R = apellido_R;
                Calle = calle;
                Numero = numero;
            }
        public class ArchivoJson<T>
        {
            public List<T> Arreglo = new List<T>();
            public string J;
            public ArchivoJson(string r)
            {
                J = r;
            }
            public void CargarArchivo()
            {
                Arreglo = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(@"D:\PIA Programacion\PIA\bin\debug\Visita.json"));
            }
            public void Agregar(T nuevodato)
            {
                Arreglo.Add(nuevodato);
                Guardar();
            }
            public void Guardar()
            {
                string FileJson = JsonConvert.SerializeObject(Arreglo);
                File.WriteAllText(@"D:\PIA Programacion\PIA\bin\debug\Visita.json", FileJson);
            }
            public List<T> Buscar(Func<T, bool> K)
            {
                return Arreglo.Where(K).ToList();
            }

            public void Actualizar(Func<T, bool> K, T agrega)
            {
                Arreglo = Arreglo.Select(v =>
                {
                    if (K(v)) v = agrega;
                    return v;
                }).ToList();
                Guardar();
            }
        }
    }
}
