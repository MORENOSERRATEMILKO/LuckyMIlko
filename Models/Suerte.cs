using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

/*SuerteId -> contiene del 1 al 10

Detalle->Descripción de la buena o mala suerte que le llegará

Imagen -> Enlace de imagen relacionada a la suerte

Realizar la función GET de nombre "Lucky" que devuelva aleatoriamente el modelo de un asuerte. (60% código, 15% postman)

Cargar la solución en azrure. (5%) */


namespace LuckyMIlko.Models
{
    public enum Suertetype

    {
        ganaste_la_loteria = 1,
        te_atropellaron = 2,
        sacaste_100_en_el_parcial = 3,
        mordiste_un_gusano_al_morder_una_manzana = 4,
        se_frego_tu_disco_duro = 5,
        te_enfermaste = 6,
        tu_perro_se_escapo = 7,
        pillaste_10_pesos_en_el_piso = 8,
        te_sacaste_99_en_el_parcial = 9,
        Te_pica_un_bicho = 10
    }

    public class Suerte
    {
        [Key]
        
        public int SuerteId { get; set; }
       
        [Required(ErrorMessage ="El Nombre de la suerte es requerido")]
        [StringLength(60, MinimumLength =2, ErrorMessage ="el nombre debe estar entre 2 y 60 letras")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El link de la foto de la suerte es requerido")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "el link debe estar entre 2 y 100 letras")]
        public string Link { get; set; }

        public Suertetype Suertes { get; set; }


    }
}
