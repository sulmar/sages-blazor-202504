﻿using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Models;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public string City { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public decimal Balance { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}

// Walidacja za pomocą DataAnnotations
/*
public class Customer : BaseEntity
{
    [Required, StringLength(20, MinimumLength = 3)]
    public string Name { get; set; }

    [Required]
    public string City { get; set; }

    [RegularExpression("^[A-Z]ello$")]
    public string Description { get; set; }
    public bool IsActive { get; set; }

    [Range(0, 1000)]
    public decimal Balance { get; set; }

    [MinLength(5)]
    public string Password { get; set; }

    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; }
}

*/