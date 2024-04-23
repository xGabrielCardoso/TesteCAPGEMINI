﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TesteCAPGEMINI.Models;

public partial class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    [DisplayName("Nome")]
    public string Nome { get; set; }

    public int? Idade { get; set; }

    [Required]
    [Column("CPF")]
    [StringLength(15)]
    [Unicode(false)]
    [DisplayName("CPF")]
    public string Cpf { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    [DisplayName("Endereço")]
    public string Endereco { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Bairro { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Estado { get; set; }

    [Required]
    [Column("UF")]
    [StringLength(2)]
    [Unicode(false)]
    [DisplayName("UF")]
    public string Uf { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Celular { get; set; }

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}