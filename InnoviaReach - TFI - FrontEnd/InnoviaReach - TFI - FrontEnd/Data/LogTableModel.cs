namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class LogTableModel
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public string? Level { get; set; }
        public DateTime? Timestamp { get; set; }
        public string? Exception { get; set; }
        public string? LogEvent { get; set; }
        public int? ReferenceNumber { get; set; }
        public string? ReferenceType { get; set; }
    }
}
