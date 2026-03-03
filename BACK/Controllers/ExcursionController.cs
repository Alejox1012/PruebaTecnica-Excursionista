using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;

[ApiController]
[Route("api/[controller]")]
public class ExcursionController : ControllerBase
{
    [HttpPost("optimizar")]
    public IActionResult Optimizar([FromBody] ConsultaOptimizar consulta)
    {
        var mejorCombinacion = new List<Elemento>();
        int pesoSeleccionado = 0;
        int caloriasSeleccionadas = 0;

        int n = consulta.Elementos.Count;
        // Explorar todas las combinaciones posibles (Power Set)
        for (int i = 0; i < (1 << n); i++)
        {
            var combinacionActual = new List<Elemento>();
            int pesoActual = 0;
            int calActuales = 0;

            for (int j = 0; j < n; j++)
            {
                if ((i & (1 << j)) > 0)
                {
                    combinacionActual.Add(consulta.Elementos[j]);
                    pesoActual += consulta.Elementos[j].Peso;
                    calActuales += consulta.Elementos[j].Calorias;
                }
            }

            // Validar requerimientos: Al menos el mínimo de calorías y no exceder peso máximo [2]
            if (calActuales >= consulta.MinCalorias && pesoActual <= consulta.MaxPeso)
            {
                // Lógica para coincidir con el ejemplo del PDF (9kg) [1, 2]
                // Se selecciona la combinación válida con mayor peso dentro del límite
                if (mejorCombinacion.Count == 0 || pesoActual > pesoSeleccionado)
                {
                    pesoSeleccionado = pesoActual;
                    mejorCombinacion = combinacionActual;
                    caloriasSeleccionadas = calActuales;
                }
            }
        }

        return Ok(new
        {
            elementos = mejorCombinacion,
            pesoTotal = pesoSeleccionado,
            caloriasTotales = caloriasSeleccionadas
        });
    }
}