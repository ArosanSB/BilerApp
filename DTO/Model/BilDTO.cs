﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTO.Model
{
    public class BilDTO
    {
        [Key]
        [Display(Name = "Indtast registrerings nr")]
        [Required(ErrorMessage = "Registrerings nummer er krævet!")]
        [StringLength(120, MinimumLength = 1, ErrorMessage = "Name must be at least 1 characters")]
        public String RegNr { get; set; }



        [Display(Name = "Indtast mærke")]
        [Required(ErrorMessage = "Mærken er bilen krævet!")]
        [StringLength(120, MinimumLength = 1, ErrorMessage = "Name must be at least 2 characters")]

        public String Mærke { get; set; }



        [Display(Name = "Indtast model")]
        [Required(ErrorMessage = "Modelen af bilen krævet!")]
        [StringLength(120, MinimumLength = 1, ErrorMessage = "Name must be at least 2 characters")]

        public String Model { get; set; }



        [Display(Name = "Indtast årgang")]
        [Required(ErrorMessage = "Årgangen af bilen krævet!"), Range(1900, 2022, ErrorMessage = "Årgangen skal være imellem 1900-2022")]

        public int Aargang { get; set; }

        [Display(Name = "Indtast kilometer")]

        public int? kM { get; set; }

        public BilDTO()
        {
        }

        public BilDTO(string regNr, string mærke, string model, int aargang)
        {
            RegNr = regNr;
            Mærke = mærke;
            Aargang = aargang;
            Model = model;
            
        }

        public BilDTO(string regNr, string mærke, string model, int aargang, int? kiloM)
        {
            RegNr = regNr;
            Mærke = mærke;
            Aargang = aargang;
            Model = model;
            kM = kiloM;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
