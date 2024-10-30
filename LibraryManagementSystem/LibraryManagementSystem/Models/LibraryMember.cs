using LibraryManagementSystem.Enums;
using System.Diagnostics.Metrics;

namespace LibraryManagementSystem.Models;

public sealed class LibraryMember : Person
{
    private int _add;

    public DateTime MembershipDate { get; set; }
    public LibraryMemberStatusEnum LibraryMemberStatus { get; internal set; }

    public LibraryMember(string name) : base(name)
    {
    }
    public LibraryMember(string title, int? publicationYear) : base(title, publicationYear)
    {
        _add++;
        Id = _add;

    }

}

