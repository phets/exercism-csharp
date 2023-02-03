using System;

static class Badge {
    public static string Print(int? id, string name, string? department) {

        string strBadge;
        if (department== null) { department= "OWNER"; }
        if (id == null) {
            strBadge = $"{name} - {department.ToUpper()}";
        }
        else
        {
            strBadge = $"[{id}] - {name} - {department.ToUpper()}";
        }
        return strBadge;
    }
}
