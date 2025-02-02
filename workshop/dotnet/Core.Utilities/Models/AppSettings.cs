using System.Text.Json.Serialization;

namespace Core.Utilities.Models;

public record AppSettings (
    OpenAI OpenAI,
    StockService StockService
);

public record OpenAI (
    string Endpoint,
    string DeploymentName,
    string ApiKey
);

public record StockService (
    string ApiKey
);