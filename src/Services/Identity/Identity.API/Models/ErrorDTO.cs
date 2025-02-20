﻿using Newtonsoft.Json;

namespace Identity.API.Models
{
    public class ErrorDTO
    {
        public int Code { get; set; }
        public string Message { get; set; } 
        public override string ToString()    
        {       
            return JsonConvert.SerializeObject(this);    
        } 
    }
}
