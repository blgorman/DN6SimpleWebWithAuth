using System.Text.Json.Serialization;
using DN6SimpleWebWithAuth.Models;

namespace DN6SimpleWebWithAuth;

/// <summary>
/// JSON serializer context for .NET 8 AOT and performance optimizations
/// </summary>
[JsonSerializable(typeof(State))]
[JsonSerializable(typeof(List<State>))]
[JsonSerializable(typeof(ErrorViewModel))]
public partial class AppJsonSerializerContext : JsonSerializerContext
{
}