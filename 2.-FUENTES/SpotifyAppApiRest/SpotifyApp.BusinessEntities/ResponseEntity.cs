using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyApp.BusinessEntities
{
    public class ResponseEntity
    {        
        public string Message { set; get; }
        public bool Status { set; get; }
        public DateTime Date { set; get; }
    }
}
