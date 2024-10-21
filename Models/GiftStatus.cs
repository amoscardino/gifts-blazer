using System.Text.Json.Serialization;

namespace GiftsBlazor.Models;

[JsonConverter(typeof(JsonStringEnumConverter<GiftStatus>))]
public enum GiftStatus
{
    Idea,
    Purchased,
    Arrived,
    Wrapped,
}
