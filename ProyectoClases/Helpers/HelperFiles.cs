using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        //NECESITAMOS DOS METODOS: LEER Y ESCRIBIR
        //LOS METODOS DEBEN SER ASINCRONOS
        //EN LOS METODOS DE CLASE NO GRAFICA DEBEMOS UTILIZAR
        //LA CLASE TASK PARA METODOS ASINCRONOS
        //NO SE UTILIZA VOID
        //1) Si es un void, se utiliza Task
        //2) Si es un return, se utiliza Task<ClaseReturn>
        public async Task WriteFileAsync(string path, string content)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(content);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        public async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }
    }
}
