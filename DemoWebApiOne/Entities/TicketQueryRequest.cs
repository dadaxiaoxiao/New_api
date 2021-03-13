using System.ComponentModel.DataAnnotations;

namespace DemoWebApiOne.Entities
{ 
    public class TicketQueryRequest
    {
        [Required(ErrorMessage ="1001")]
        public string plant {get;set;}    

       [Required(ErrorMessage ="1001")]    
        public string ticket { get; set; }
        
        // public object result{get;set;}

    }
}