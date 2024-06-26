﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TesteCAPGEMINI.Models;

public partial class VwPedido
{
    [Required]
    [StringLength(255)]
    [Unicode(false)]
    [DisplayName("Nome do Cliente")]
    public string NomeCliente { get; set; }

    [Required]
    [Column("CPF")]
    [StringLength(15)]
    [Unicode(false)]
    [DisplayName("CPF")]
    public string Cpf { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    [DisplayName("Nome do Produto")]
    public string NomeProduto { get; set; }

    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdProduto { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    [DisplayName("Endereço da Entrega")]
    public string EnderecoEntrega { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Status { get; set; }

    [DisplayName("Valor do Frete")]
    public string ValorFrete { get; set; }

    [DisplayName("Valor Total")]
    public string ValorTotal { get; set; }
}