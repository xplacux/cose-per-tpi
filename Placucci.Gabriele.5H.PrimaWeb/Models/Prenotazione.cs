using System;
using System.ComponentModel.DataAnnotations;

namespace Placucci.Gabriele._5H.PrimaWeb.Models
{
    public class Prenotazione
    {
        public int PrenotazioneId {get; set;}
        public string Nome { get; set; }
            
        [Required(ErrorMessage="Inserisci una email valida")]
        [EmailAddress]    
        public string Email { get; set; }
    }
}
