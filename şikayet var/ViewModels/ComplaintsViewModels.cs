using System;
using System.ComponentModel.DataAnnotations;

namespace şikayet_var.ViewModels;

public class ComplaintsViewModels
{
    [Display(Title ="Başlık")]
    [Required(ErrorMessage ="Başlık kısmı boş bırakılamaz!")]
public string Title { get; set; }
public string Description { get; set; }
public DateTime CreatedAt { get; set; }
public string ImagePath { get; set; }
}
