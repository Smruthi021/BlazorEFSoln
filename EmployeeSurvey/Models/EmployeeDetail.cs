using System;
using System.Collections.Generic;

namespace EmployeeSurvey.Models;

public partial class EmployeeDetail
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Department { get; set; }

    public string? JobTitle { get; set; }

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public DateOnly? DateOfJoining { get; set; }

    public string? EmploymentType { get; set; }

    public string? Status { get; set; }
}
