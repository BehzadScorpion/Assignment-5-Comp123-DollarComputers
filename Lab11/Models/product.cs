namespace DollarComputers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public short productID { get; set; }

        [Column(TypeName = "money")]
        public decimal? cost { get; set; }

        [StringLength(255)]
        public string manufacturer { get; set; }

        [StringLength(255)]
        public string model { get; set; }

        [StringLength(255)]
        public string RAM_type { get; set; }

        [StringLength(255)]
        public string RAM_size { get; set; }//5

        [StringLength(255)]
        public string displaytype { get; set; }//6

        [StringLength(255)]
        public string screensize { get; set; }//7

        [StringLength(255)]
        public string resolution { get; set; }//8

        [StringLength(255)]
        public string CPU_Class { get; set; }//9

        [StringLength(255)]
        public string CPU_brand { get; set; }//10

        [StringLength(255)]
        public string CPU_type { get; set; }//11

        [StringLength(255)]
        public string CPU_speed { get; set; }//12

        [StringLength(255)]
        public string CPU_number { get; set; }//13

        [StringLength(255)]
        public string condition { get; set; }//14

        [StringLength(255)]
        public string OS { get; set; }//15

        [StringLength(255)]
        public string platform { get; set; }//16

        [StringLength(255)]
        public string HDD_size { get; set; }//17

        [StringLength(255)]
        public string HDD_speed { get; set; }//18

        [StringLength(255)]
        public string GPU_Type { get; set; }//19

        [StringLength(255)]
        public string optical_drive { get; set; }//20

        [StringLength(255)]
        public string Audio_type { get; set; }//21

        [StringLength(255)]
        public string LAN { get; set; }//22

        [StringLength(255)]
        public string WIFI { get; set; }//23

        [StringLength(255)]
        public string width { get; set; }//24

        [StringLength(255)]
        public string height { get; set; }//25

        [StringLength(255)]
        public string depth { get; set; }//26

        [StringLength(255)]
        public string weight { get; set; }//27

        [StringLength(255)]
        public string moust_type { get; set; }//28

        [StringLength(255)]
        public string power { get; set; }//29

        [StringLength(255)]
        public string webcam { get; set; }//30
    }
}
