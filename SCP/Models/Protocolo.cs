using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCP.Models
{
  public enum StatusDocumentoEnum
  {
    Normal, Urgente
  }

  public class Protocolo
  {
    public int Id { get; set; }

    [Required]
    [Display(Name = "Data Recebimento")]
    public DateTime DataRecebimento { get; set; }

    [Required]
    [MinLength(6)]
    public string Remetente { get; set; }

    [Required]
    [MinLength(6)]
    public string Interessado { get; set; }

    [Required]
    [MinLength(6)]
    public string Assunto { get; set; }

    [Required]
    public StatusDocumentoEnum Status { get; set; }
    
    public string Autenticador { get; private set; }

    public Protocolo()
    {
      this.Autenticador = Guid.NewGuid().ToString();
    }

    //public List<SelectListItem> GerarListaStatus()
    //{
    //  return new List<SelectListItem>{
    //    new SelectListItem{Text = "Urgente", Value = "Urgente"},
    //    new SelectListItem{Text = "Normal", Value = "Normal", Selected = true}
    //  };
    //}
  }
}