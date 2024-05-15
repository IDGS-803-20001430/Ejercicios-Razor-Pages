using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ListaDeProgramasEnRazo.Pages
{   
    public class programa1Model : PageModel
    {
        //DEFINIMOS LOS ATRIBUTOS
        [BindProperty]
        public string peso { get; set; } = "";
        [BindProperty]
        public string altura { get; set; } = "";
        public double Calculo = 0;

        public void OnPost()
        {
            double Peso = Convert.ToDouble(peso);
            double Altura = Convert.ToDouble(altura);
            Altura = Altura / 100;
            Calculo = Peso / (Altura * Altura);

            ModelState.Clear();
        }
    }
}
