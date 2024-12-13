using System.Text.Json;

namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class LogTableModel
    {
        public string Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Level { get; set; }
        public string MessageTemplate { get; set; }
        public string RenderedMessage { get; set; }
        public string? Exception { get; set; }
        public LogProperties Properties { get; set; }
        public Renderings Renderings { get; set; }
        public string? UtcTimestamp { get; set; }
    }

    public class LogProperties
    {
        public string MethodName { get; set; }
        public string KeyId { get; set; }
        public string Element { get; set; }
        public string State { get; set; }
        public EventId EventId { get; set; }
        public string SourceContext { get; set; }
        public string ActionId { get; set; }
        public string ActionName { get; set; }
        public string RequestId { get; set; }
        public string RequestPath { get; set; }
        public string UserName { get; set; }
    }

    public class EventId
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Renderings
    {
        public List<Rendering> KeyId { get; set; }
        public List<KeyIdItem> State { get; set; }
    }

    public class Rendering
    {
        public string Format { get; set; }
        public string RenderingId { get; set; }
    }

    public class KeyIdItem
    {
        public string Format { get; set; }
        public string Rendering { get; set; }
    }
}
