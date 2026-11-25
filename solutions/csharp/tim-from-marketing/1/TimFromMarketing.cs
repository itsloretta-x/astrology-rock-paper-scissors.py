static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
       string dept = department == null ? "OWNER" : department.ToUpper();
        return id == null ? $"{name} - {dept}" : $"[{id}] - {name} - {dept}"; 
    }
}
