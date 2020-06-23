using System;
using System.ComponentModel.DataAnnotations;

namespace AssetsIT.API.Models.Response
{
    public class CustomerCessationUpdateDTO
    {
        public int IdUser { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateEndcontrat { get; set; }
    }
}