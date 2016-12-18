using System.ComponentModel.DataAnnotations;

namespace jmWebApi.data {

       public class equipment_vendor {
            [Key]
            public int Id { get; set; }
            public string descr { get; set; }
        } 

}