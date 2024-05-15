using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ListaDeProgramasEnRazo.Pages
{
    public class programa2Model : PageModel
    {
        [BindProperty]
        public string Mensaje { get; set; }

        [BindProperty]
        public int N { get; set; }

        [BindProperty]
        public string Operacion { get; set; }

        public string Resultado { get; set; }

        public void OnPost()
        {
            if (Operacion == "codificar")
            {
                Resultado = CodificarMensaje(Mensaje.ToUpper(), N);
            }
            else if (Operacion == "decodificar")
            {
                Resultado = DecodificarMensaje(Mensaje.ToUpper(), N);
            }
        }

        private string CodificarMensaje(string mensaje, int n)
        {
            string mensajeCodificado = "";
            foreach (char c in mensaje)
            {
                if (char.IsLetter(c))
                {
                    int codigoAscii = (int)c;
                    int codigoModificado = ((codigoAscii - 65 + n) % 26) + 65;
                    mensajeCodificado += (char)codigoModificado;
                }
                else
                {
                    mensajeCodificado += c;
                }
            }
            return mensajeCodificado;
        }

        private string DecodificarMensaje(string mensaje, int n)
        {
            string mensajeDecodificado = "";
            foreach (char c in mensaje)
            {
                if (char.IsLetter(c))
                {
                    int codigoAscii = (int)c;
                    int codigoModificado = ((codigoAscii - 65 - n + 26) % 26) + 65;
                    mensajeDecodificado += (char)codigoModificado;
                }
                else
                {
                    mensajeDecodificado += c;
                }
            }
            return mensajeDecodificado;
        }
    }
}
